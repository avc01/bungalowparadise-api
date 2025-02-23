namespace bungalowparadise_api.Models
{
    public class PasswordReset
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public required string ResetToken { get; set; }
        public DateTime ExpiresAt { get; set; }

        // Navigation property
        public User? User { get; set; }
    }
}
