namespace bungalowparadise_api.Models
{
    public class Room
    {
        public int Id { get; set; }
        public required string RoomNumber { get; set; }
        public required string Type { get; set; }
        public double Price { get; set; }
        public required string Status { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation property
        public ICollection<Reservation>? Reservations { get; set; }
        public ICollection<ReservationRoom>? ReservationRooms { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
