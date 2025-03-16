namespace bungalowparadise_api.Models.DTOs
{
    public class RoomDto
    {
        public required string Name { get; set; }
        public required string RoomNumber { get; set; }
        public required string Type { get; set; }
        public double Price { get; set; }
        public required string Status { get; set; }
        public required string Description { get; set; }
        public int Beds { get; set; }
        public int Bathrooms { get; set; }
        public int GuestsPerRoom { get; set; }
    }
}
