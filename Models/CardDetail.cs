namespace bungalowparadise_api.Models
{
    public class CardDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime ExpiredDate { get; set; }
        public long CardNumber { get; set; }
        public int CardCode { get; set; }
        public required string CardHolderName { get; set; }

        // Navigation property
        public User? User { get; set; }
    }
}
