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

        // Navigation property
        public User? User { get; set; }
        public ICollection<Room>? Rooms { get; set; }
        public ICollection<ReservationRoom>? ReservationRooms { get; set; }
        public ICollection<Payment>? Payments { get; set; }
    }
}
