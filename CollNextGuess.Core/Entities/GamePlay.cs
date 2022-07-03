using CollNextGuess.Core.Interfaces;
using Newtonsoft.Json;

namespace CollNextGuess.Core.Entities
{
    public class GamePlay : Game, IDeckManager, IPlayerManagement, IEntity
    {
        public int Id { get; set; }

        public GamePlay(int numberOfPLayers, List<string> players) : base(numberOfPLayers, players)
        {
            this.Players = base.Players;
            this.IsMultiPlayer = base.IsMultiPlayer;
            this.NumberOfPlayers = base.NumberOfPlayers;
            this.IsActive = base.IsActive;
            this.GameCard = SetCardGame(InGameCardDeck.GameDeck);
            this.InGameCardDeck = GetInGameCardDeck(GameCard);
            this.CurrentRound = SetCurrentRound();
        }

        public InGameCardDeck GetInGameCardDeck(Card cardGame)
        {
            this.InGameCardDeck.GameDeck.Remove(cardGame);
            return InGameCardDeck;
        }

        public Card SetCardGame(List<Card> cards)
        {
            var random = new Random();

            var index = random.Next(cards.Count);
            return cards[index];
        }

        public Player SetActivePLayer()
        {
            return this.Players.Where(player => player.IsActive).FirstOrDefault();
        }

        private int SetCurrentRound()
        {
            return 52 - this.InGameCardDeck.GameDeck.Count;
        }
    }
}
