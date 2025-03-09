using bungalowparadise_api.ConfigModels;
using bungalowparadise_api.DbContext;
using bungalowparadise_api.Models;
using MailKit.Net.Smtp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MimeKit;

namespace bungalowparadise_api.HostedServices
{
    public class EmailNotificationService(
        IServiceProvider serviceProvider, 
        IOptions<EmailSettings> emailSettings) : BackgroundService
    {
        private const string NotificationOneWeekInAdvance = "Recordatorio de Reserva: Semana de Antelacion";
        private const string NotificationOneHourInAdvance = "Recordatorio de Reserva: Hora de Antelacion";

        private readonly IServiceProvider _serviceProvider = serviceProvider;
        private readonly EmailSettings _emailSettings = emailSettings.Value;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var upcomingReservations = await this.GetReservationsToSendNotificationAsync(stoppingToken);

                foreach (var reservation in upcomingReservations)
                {
                    try
                    {
                        // await SendEmailAsync(reservation.User.Email, reservation);
                        await UpdateNotificationStatusAsync(reservation, "Sent");
                    }
                    catch (Exception)
                    {
                        await UpdateNotificationStatusAsync(reservation, "Not Sent: Error");
                    }
                    finally 
                    {
                        // Avoid Google detecting Spam by waiting 5 seconds each time.
                        await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
                    }
                        
                }

                await Task.Delay(TimeSpan.FromMinutes(10), stoppingToken);
            }
        }

        private async Task<IEnumerable<Reservation>> GetReservationsToSendNotificationAsync(CancellationToken stoppingToken) 
        {
            using var scope = _serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<HotelDbContext>();

            var upcomingReservations = await dbContext.Reservations
                .Include(r => r.User)
                .Include(r => r.Notifications)
                .Where(r =>
                    (r.CheckIn > DateTime.UtcNow && r.CheckIn < DateTime.UtcNow.AddDays(7) && !r.Notifications.Any(n => n.Message == NotificationOneWeekInAdvance)) ||
                    (r.CheckIn > DateTime.UtcNow && r.CheckIn < DateTime.UtcNow.AddHours(1) && !r.Notifications.Any(n => n.Message == NotificationOneHourInAdvance)))        
                .ToListAsync(cancellationToken: stoppingToken);

            return upcomingReservations;
        }

        private async Task SendEmailAsync(string recipientEmail, Reservation reservation)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Hotel Reservations", _emailSettings.GmailUser));
            message.To.Add(new MailboxAddress("", recipientEmail));
            message.Subject = "Recortadorio de su Reserva con Bundalow Paradise!";

            string htmlBody = $@"<html>
                <body style='font-family: Arial, sans-serif; padding: 20px; background-color: #f4f4f4;'>
                    <div style='max-width: 600px; margin: auto; background: white; padding: 20px; border-radius: 10px; box-shadow: 0 2px 10px rgba(0,0,0,0.1);'>
                        <h2 style='color: #333; text-align: center;'>Recordatorio de su Reserva</h2>
                        <hr style='border: 1px solid #ddd;'>
                        <p>Estimado/a <strong>{reservation.User?.Name}</strong>,</p>
                        <p>Nos complace recordarle su próxima reserva en nuestro hotel.</p>
                        <p><strong>Fecha de Check-in:</strong> {reservation.CheckIn:dddd, dd 'de' MMMM 'de' yyyy}</p>
                        <p><strong>Número de Huéspedes:</strong> {reservation.NumberOfGuests}</p>
                        <p><strong>Estado:</strong> {reservation.Status}</p>
                        <p>Esperamos tener el placer de recibirle. Si tiene alguna pregunta, no dude en contactarnos.</p>
                        <p style='text-align: center;'>
                            <a href='https://yourhotelwebsite.com' style='background-color: #007bff; color: white; padding: 10px 20px; text-decoration: none; border-radius: 5px;'>Ver Reserva</a>
                        </p>
                        <hr style='border: 1px solid #ddd;'>
                        <p style='text-align: center; color: #888;'>¡Gracias por elegir nuestro hotel!<br>Que tenga un excelente día.</p>
                    </div>
                </body>
            </html>";

            message.Body = new TextPart("html") { Text = htmlBody };

            using var client = new SmtpClient();
            await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
            await client.AuthenticateAsync(_emailSettings.GmailUser, _emailSettings.GmailAppPassword);
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }

        private async Task UpdateNotificationStatusAsync(Reservation reservation, string status) 
        {
            using var scope = _serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<HotelDbContext>();

            var isHourlyNotification = reservation.CheckIn < DateTime.UtcNow.AddHours(1);

            var newNotification = new Notification()
            {
                ReservationId = reservation.Id,
                Message = isHourlyNotification ? NotificationOneHourInAdvance: NotificationOneWeekInAdvance,
                Status = status,
            };

            await dbContext.AddAsync(newNotification);
            await dbContext.SaveChangesAsync();
        }
    }
}
