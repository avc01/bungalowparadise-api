namespace bungalowparadise_api.Models.DTOs
{
    public class CardDto
    {
        public required string Id { get; set; }
        public required string CardNumber { get; set; }
        public required string CardHolder { get; set; }
        public required string ExpiryMonth { get; set; }
        public required string ExpiryYear { get; set; }
        public required string CardType { get; set; }
        public required string CVV { get; set; }
    }
}
