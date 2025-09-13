namespace BlackjackBot.Data.Models
{
    public class Hand
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public long UserId { get; set; }
        public Guid SessionId { get; set; }
        public List<Card>? Cards { get; set; } = new List<Card> { };
        public int Bet { get; set; }
        public bool IsStopped { get; set; }

        public User? User { get; set; }
        public Session? Session { get; set; }
    }
}
