using bungalowparadise_api.Models;

namespace bungalowparadise_api.HostedServices.MailTemplates
{
    public class ReminderMailTemplate
    {
        public static string GetReminderTemplate(Reservation reservation) 
        {
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

            return htmlBody;
        }
    }
}
