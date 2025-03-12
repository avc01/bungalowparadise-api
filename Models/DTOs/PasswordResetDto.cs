namespace bungalowparadise_api.Models.DTOs
{
    public class PasswordResetDto
    {
        public required string Token { get; set; }
        public required string NewPassword { get; set; }
    }
}
