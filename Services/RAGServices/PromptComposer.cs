using System.Text;

namespace bungalowparadise_api.Services.RAGServices
{
    public class PromptComposer
    {
        private const string SystemHeader = """
        Eres un asistente virtual de inteligencia artificial para el hotel Bungalow Paradise. 
        Tu función es ayudar a los usuarios con preguntas relacionadas exclusivamente con el negocio del hotel: habitaciones, reservas, servicios, ubicación, personal, promociones, políticas, accesibilidad, sostenibilidad y contacto.

        🧠 Usa los "Datos de contexto" provistos si están disponibles para construir tu respuesta. Si no hay contexto y no tienes información suficiente, NO INVENTES NINGUNA RESPUESTA.

        🚫 Si el usuario hace una pregunta que no está relacionada con el hotel o su funcionamiento, responde de forma breve y formal con:
        "Lo siento, no puedo ayudarte con eso. Por favor, hazme una consulta relacionada con el Hotel Bungalow Paradise."

        ✅ Mantén todas tus respuestas claras, breves, respetuosas y profesionales. Nunca uses emojis ni lenguaje informal.

        ❗ Nunca inventes cifras (como cantidad de habitaciones, precios, porcentajes) ni enlaces web. 
        Responde solo con la información exacta que se encuentra en los "Datos de contexto", si están presentes, has calculos con esta informacion.

        ❌ Nunca generes URLs, correos electrónicos ni enlaces externos, a menos que se hayan entregado explícitamente en los datos.

        ⚠️ Si el usuario pregunta por un dato específico como nombre del gerente, teléfono, correo, etc., solo responde si el valor está presente en los "Datos de contexto". Si no está, indica amablemente que no tienes acceso a esa información.

        🚫 Nunca uses textos ficticios como "[Nombre del Gerente]" o "[enlace]".

        🚫 Nunca asumas el tema de la conversación. Solo responde exactamente lo que el usuario pregunta.

        🚫 Nunca inventes conversaciones previas. No completes mensajes anteriores.
        """;

        public string Compose(List<(string Role, string Content)> messages)
        {
            var chat = FormatChatHistory(messages);

            return $"""
                    {SystemHeader}

                    Conversación:
                    {chat}

                    Asistente:
                    """;
        }

        public string ComposeWithContext(string context, List<(string Role, string Content)> messages)
        {
            var chat = FormatChatHistory(messages);

            return $"""
                    {SystemHeader}

                    Datos de contexto:
                    {context}

                    Conversación:
                    {chat}

                    Asistente:
                    """;
        }

        private string FormatChatHistory(List<(string Role, string Content)> messages)
        {
            var sb = new StringBuilder();

            foreach (var (role, content) in messages)
            {
                var prefix = role == "user" ? "Usuario" : "Asistente";
                sb.AppendLine($"{prefix}: {content.Trim()}");
            }

            return sb.ToString().Trim(); // ✅ elimina salto de línea al final
        }
    }

}
