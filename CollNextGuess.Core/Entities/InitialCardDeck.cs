namespace CollNextGuess.Core.Entities
{
    public class InitialCardDeck : IEntity
    {
        public int Id { get; set; }

        public List<Card>? InitialDeck { get; set; } = new List<Card>();
    }
}
