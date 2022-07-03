using CollNextGuess.Core.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollNextGuess.Core.Entities
{
    public abstract class Game
    {
        private List<string> _playerNames;

        private List<Player> _players;

        public Game(int numberOfPLayers, List<string> players)
        {
            InGameCardDeck = BuildDeck();
            NumberOfPlayers = numberOfPLayers;
            IsMultiPlayer = Multiplayer();
            _playerNames = players;
        }

        public int Id { get; set; }

        public bool IsMultiPlayer { get; set; }

        public int NumberOfPlayers { get; set; }

        public bool IsActive { get; set; } = true;

        [NotMapped]
        public Card? GameCard { get; set; }

        public List<string> PlayerNames
        {
            get { return _playerNames; }
            set { _playerNames = value; }
        }

        public  List<Player>? Players {
            get => _players;
            set
            {
                List<Player> newPlayers = new List<Player>();

                for (int i = 0; i < NumberOfPlayers; i++)
                {
                    if (string.IsNullOrEmpty(_playerNames[i]) || _playerNames[i] == "string")
                    {
                        newPlayers.Add(new Player($"New_player_{i + 1}", i + 1, 0));
                    }
                    else
                    {
                        newPlayers.Add(new Player(_playerNames[i], i + 1, 0));
                    }
                }
                
                _players = newPlayers;
            }
        }

        public int CurrentRound { get; set; }

        [NotMapped]
        public  InGameCardDeck InGameCardDeck { get; set; }

        private InGameCardDeck BuildDeck()
        {
            
            var deck = new InGameCardDeck();
            var cardDeck = deck.GameDeck;
            RanksEnum[] values = (RanksEnum[])Enum.GetValues(typeof(RanksEnum));
            foreach (var suit in Enum.GetNames(typeof(SuitsEnum)))
            {
                for (int i = 0; i < values.Length; i++)
                {
                    var card = new Card();
                    card.Suit = suit;
                    switch (i)
                    {
                        case 0:
                            card.Rank = values[i].ToString();
                            break;
                        case 11:
                            card.Rank = values[i].ToString();
                            break;
                        case 12:
                            card.Rank = values[i].ToString();
                            break;
                        case 13:
                            card.Rank = values[i].ToString();
                            break;
                        default:
                            card.Rank = i.ToString();
                            break;
                    }
                    cardDeck.Add(card);
                }

            }
            deck.GameDeck = cardDeck;
            return deck;
        }

        private bool Multiplayer()
        {
            return NumberOfPlayers > 1;
        }

    }
}
