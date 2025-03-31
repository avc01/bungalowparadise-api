namespace bungalowparadise_api.Models.DTOs
{
    public class ReservationConfirmationDto
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public required IEnumerable<int> RoomIds { get; set; }
        public required string CardNumber { get; set; }
        public required string CardName { get; set; }
        public required string ExpiryMonth { get; set; }
        public required string ExpiryYear { get; set; }
        public required string CVV { get; set; }
        public double TotalAmount { get; set; }
    }
}
