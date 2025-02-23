namespace bungalowparadise_api.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public required string Message { get; set; }
        public required string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property
        public User? User { get; set; }
    }
}
