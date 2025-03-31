using Amazon.S3.Model;
using bungalowparadise_api.Models.DTOs;

namespace bungalowparadise_api.HostedServices.MailTemplates
{
    public class ReceiptMailTemplate
    {
        public static string GetReceiptTemplate(ReservationConfirmationDto reservationConfirmationDto, string reservationCode)
        {
            var html = $@"
            <!DOCTYPE html>
            <html lang=""es"">
            <head>
              <meta charset=""UTF-8"" />
              <title>Recibo de Reserva</title>
            </head>
            <body style=""font-family: Arial, sans-serif; background-color: #f4f4f4; padding: 20px;"">
              <div style=""max-width: 600px; margin: auto; background-color: #ffffff; border-radius: 8px; padding: 30px; box-shadow: 0 2px 6px rgba(0,0,0,0.1);"">
    
                <h2 style=""color: #2c3e50;"">🛎️ Recibo de Reserva</h2>
                <p>Hola <strong>{reservationConfirmationDto.UserEmail}</strong>,</p>
                <p>¡Gracias por tu reserva! A continuación, encontrarás los detalles de tu estadía:</p>

                <hr style=""margin: 20px 0;"" />

                <h3 style=""color: #2c3e50;"">🆔 Código de Reserva</h3>
                <p><strong>Código:</strong> {reservationCode}</p>

                <h3 style=""color: #2c3e50;"">🗓️ Detalles de la Estadía</h3>
                <p><strong>Entrada:</strong> {reservationConfirmationDto.CheckIn:dd MMM yyyy}</p>
                <p><strong>Salida:</strong> {reservationConfirmationDto.CheckOut:dd MMM yyyy}</p>
                <p><strong>Habitación(es):</strong> {string.Join(", ", reservationConfirmationDto.RoomIds)}</p>

                <hr style=""margin: 20px 0;"" />

                <h3 style=""color: #2c3e50;"">💳 Información de Pago</h3>
                <p><strong>Titular de la tarjeta:</strong> {reservationConfirmationDto.CardName}</p>
                <p><strong>Número de tarjeta:</strong> •••• •••• •••• {reservationConfirmationDto.CardNumber[^4..]}</p>
                <p><strong>Vencimiento:</strong> {reservationConfirmationDto.ExpiryMonth} / {reservationConfirmationDto.ExpiryYear}</p>

                <hr style=""margin: 20px 0;"" />

                <p style=""font-size: 0.9em; color: #777;"">Si tienes alguna pregunta, no dudes en responder a este correo. ¡Esperamos darte la bienvenida pronto!</p>

                <p style=""margin-top: 30px;"">Saludos cordiales,<br /><strong>El equipo del hotel</strong></p>
              </div>
            </body>
            </html>";

            return html;
        }
    }
}
