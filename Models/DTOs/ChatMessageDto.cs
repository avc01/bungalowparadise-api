namespace bungalowparadise_api.Models.DTOs
{
    public class ChatMessageDto
    {
        public string Role { get; set; } = default!; // "user" or "assistant"
        public string Content { get; set; } = default!;
    }
}
