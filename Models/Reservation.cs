namespace bungalowparadise_api.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public required string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfKids { get; set; }

        // Navigation property
        public User? User { get; set; }
        public ICollection<Room>? Rooms { get; set; }
        public ICollection<Payment>? Payments { get; set; }
        public ICollection<Notification>? Notifications { get; set; }
    }
}
