namespace bungalowparadise_api.Models.DTOs
{
    public class UserReservationViewDto
    {
        public int ReservationId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public required string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfKids { get; set; }
        public double TotalPrice { get; set; }
        public required string Location { get; set; }
        public required IEnumerable<UserReservationRoomsDto> Rooms { get; set; }
    }
}
