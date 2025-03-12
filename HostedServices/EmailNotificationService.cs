using bungalowparadise_api.ConfigModels;
using bungalowparadise_api.DbContext;
using bungalowparadise_api.HostedServices.MailTemplates;
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

        public async Task SendEmailAsync(string recipientEmail, string mailTemplate, string subject)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Hotel Online Services", _emailSettings.GmailUser));
            message.To.Add(new MailboxAddress("", recipientEmail));
            message.Subject = subject;
            message.Body = new TextPart("html") { Text = mailTemplate };

            using var client = new SmtpClient();
            await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
            await client.AuthenticateAsync(_emailSettings.GmailUser, _emailSettings.GmailAppPassword);
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var upcomingReservations = await this.GetReservationsToSendNotificationAsync(stoppingToken);

                foreach (var reservation in upcomingReservations)
                {
                    try
                    {
                        // await SendEmailAsync(reservation.User.Email, ReminderMailTemplate.GetReminderTemplate(reservation), "Recortadorio de su Reserva con Bundalow Paradise!");
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
