namespace bungalowparadise_api.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public required string PaymentMethod { get; set; }
        public double Amount { get; set; }
        public required string PaymentStatus { get; set; }
        public string? TransactionId { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property
        public Reservation? Reservation { get; set; }
    }
}
