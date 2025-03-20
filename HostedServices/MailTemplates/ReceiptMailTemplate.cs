using Amazon.S3.Model;
using bungalowparadise_api.Models.DTOs;

namespace bungalowparadise_api.HostedServices.MailTemplates
{
    public class ReceiptMailTemplate
    {
        public static string GetReceiptTemplate(ReservationConfirmationDto reservationConfirmationDto)
        {
            var html = $@"
            <!DOCTYPE html>
            <html lang=""en"">
            <head>
              <meta charset=""UTF-8"" />
              <title>Reservation Receipt</title>
            </head>
            <body style=""font-family: Arial, sans-serif; background-color: #f4f4f4; padding: 20px;"">
              <div style=""max-width: 600px; margin: auto; background-color: #ffffff; border-radius: 8px; padding: 30px; box-shadow: 0 2px 6px rgba(0,0,0,0.1);"">
    
                <h2 style=""color: #2c3e50;"">🛎️ Reservation Receipt</h2>
                <p>Hi <strong>{reservationConfirmationDto.UserEmail}</strong>,</p>
                <p>Thank you for your reservation! Below are your booking details:</p>

                <hr style=""margin: 20px 0;"" />

                <h3 style=""color: #2c3e50;"">🗓️ Stay Details</h3>
                <p><strong>Check-In:</strong> {reservationConfirmationDto.CheckIn:dd MMM yyyy}</p>
                <p><strong>Check-Out:</strong> {reservationConfirmationDto.CheckOut:dd MMM yyyy}</p>
                <p><strong>Room(s):</strong> {string.Join(", ", reservationConfirmationDto.RoomIds)}</p>

                <hr style=""margin: 20px 0;"" />

                <h3 style=""color: #2c3e50;"">💳 Payment Info</h3>
                <p><strong>Cardholder:</strong> {reservationConfirmationDto.CardName}</p>
                <p><strong>Card Number:</strong> •••• •••• •••• {reservationConfirmationDto.CardNumber[^4..]}</p>
                <p><strong>Expiry:</strong> {reservationConfirmationDto.ExpiryMonth} / {reservationConfirmationDto.ExpiryYear}</p>

                <hr style=""margin: 20px 0;"" />

                <p style=""font-size: 0.9em; color: #777;"">If you have any questions, feel free to reply to this email. We look forward to hosting you!</p>

                <p style=""margin-top: 30px;"">Best regards,<br /><strong>Your Hotel Team</strong></p>
              </div>
            </body>
            </html>";

            return html;
        }
    }
}
