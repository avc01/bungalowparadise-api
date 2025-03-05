namespace bungalowparadise_api.Models
{
    public class Review
    {
        public int Id { get; set; } 
        public int UserId { get; set; } 
        public int Rating { get; set; } 
        public required string Comment { get; set; } 
        public DateTime CreatedAt { get; set; }

        // Navigation property
        public User? User { get; set; }
    }
}
