namespace bungalowparadise_api.Models
{
    public class ReviewDto
    {
        public int UserId { get; set; }
        public required string Comment { get; set; }
        public byte Rating { get; set; }
    }
}
