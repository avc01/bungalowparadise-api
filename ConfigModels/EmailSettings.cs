namespace bungalowparadise_api.ConfigModels
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string? GmailUser { get; set; }
        public string? GmailAppPassword { get; set; }
    }
}
