namespace BlackjackBot.Data.Models
{
    public enum Rank 
    {
        Two = 2,
        Three,
        Fourth,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public enum Suit 
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }

    public record Card(Suit Suit, Rank Rank);
}
