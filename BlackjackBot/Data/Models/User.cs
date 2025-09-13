namespace BlackjackBot.Data.Models
{
    public class User
    {
        public long Id { get; set; }
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Balance { get; set; }
        public Guid? ActiveSessionId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Session? ActiveSession { get; set; }
    }
}
