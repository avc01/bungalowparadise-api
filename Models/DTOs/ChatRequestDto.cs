namespace bungalowparadise_api.Models.DTOs
{
    public class ChatRequestDto
    {
        public List<ChatMessageDto> Messages { get; set; } = new();
    }
}
