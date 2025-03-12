using bungalowparadise_api.Models;

namespace bungalowparadise_api.HostedServices.MailTemplates
{
    public class PasswordResetMailTemplate
    {
        public static string GetPasswordResetTemplate(string token, string name) 
        {
            string companyName = "Bungalow Paradise";
            string year = DateTime.UtcNow.Year.ToString();

            string emailBody = $@"
                    <!DOCTYPE html>
                    <html lang=""es"">
                    <head>
                      <meta charset=""UTF-8"" />
                      <meta name=""viewport"" content=""width=device-width, initial-scale=1.0""/>
                      <title>Código para Restablecer Contraseña</title>
                      <style>
                        body {{
                          font-family: Arial, sans-serif;
                          background-color: #f4f4f7;
                          margin: 0;
                          padding: 0;
                        }}
                        .email-container {{
                          max-width: 600px;
                          margin: 30px auto;
                          background-color: #ffffff;
                          padding: 30px;
                          border-radius: 8px;
                          box-shadow: 0 0 10px rgba(0, 0, 0, 0.05);
                        }}
                        .header {{
                          text-align: center;
                          color: #333333;
                          font-size: 24px;
                          margin-bottom: 20px;
                        }}
                        .content {{
                          color: #555555;
                          font-size: 16px;
                          line-height: 1.6;
                        }}
                        .token-box {{
                          background-color: #f0f0f5;
                          padding: 15px;
                          text-align: center;
                          font-size: 20px;
                          font-weight: bold;
                          letter-spacing: 2px;
                          border-radius: 5px;
                          margin: 20px 0;
                          color: #1a1a1a;
                        }}
                        .footer {{
                          font-size: 14px;
                          color: #999999;
                          text-align: center;
                          margin-top: 30px;
                        }}
                      </style>
                    </head>
                    <body>
                      <div class=""email-container"">
                        <div class=""header"">
                          Solicitud de Restablecimiento de Contraseña
                        </div>
                        <div class=""content"">
                          <p>Hola {name},</p>
                          <p>Hemos recibido una solicitud para restablecer tu contraseña. Usa el siguiente código para continuar con el proceso:</p>

                          <div class=""token-box"">
                            {token}
                          </div>

                          <p>Si no solicitaste el restablecimiento de tu contraseña, puedes ignorar este correo.</p>
                          <p>Gracias,<br>El equipo de soporte de {companyName}</p>
                        </div>
                        <div class=""footer"">
                          &copy; {year} {companyName}. Todos los derechos reservados.
                        </div>
                      </div>
                    </body>
                    </html>";

            return emailBody;
        }
    }
}
