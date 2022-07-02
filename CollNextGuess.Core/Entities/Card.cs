namespace CollNextGuess.Core.Entities
{
    public class Card : IEntity
    {
        public int Id { get; set; }

        public string? Suit { get; set; }

        public string? Rank { get; set; }
    }
}
