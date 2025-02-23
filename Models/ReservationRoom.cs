namespace bungalowparadise_api.Models
{
    public class ReservationRoom
    {
        public int ReservationId { get; set; }
        public required Reservation Reservation { get; set; }

        public int RoomId { get; set; }
        public required Room Room { get; set; }
    }
}
