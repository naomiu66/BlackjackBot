namespace BlackjackBot.Data.Models
{
    public class Session
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public long chatId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<Hand>? PlayerHands { get; set; } = new List<Hand> { };
        public List<Card>? DealerHand { get; set; } = new List<Card> { };
    }
}
