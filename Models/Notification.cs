namespace bungalowparadise_api.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public required string Message { get; set; }
        public required string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property
        public Reservation? Reservation { get; set; }
    }
}
