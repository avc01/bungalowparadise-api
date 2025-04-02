namespace bungalowparadise_api.Models.DTOs
{
    public class NewCardDto
    {
        public int UserId { get; set; }
        public required string CardNumber { get; set; }
        public required string CardHolder { get; set; }
        public required string ExpiryMonth { get; set; }
        public required string ExpiryYear { get; set; }
        public required string CVV { get; set; }
        public int? OldCardId { get; set; }
    }
}
