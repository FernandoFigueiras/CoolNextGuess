using CollNextGuess.Core.Entities;
using CollNextGuess.Core.Enums;

namespace CollNextGuess.Infrastructure.Services.BuildDeckService
{
    public class DeckBuilder : IDeckBuilder
    {
        public InitialCardDeck BuildInitialDeck()
        {
            var card = new Card();
            var deck = new InitialCardDeck();
            string[] names = Enum.GetNames(typeof(RanksEnum));
            RanksEnum[] values = (RanksEnum[])Enum.GetValues(typeof(RanksEnum));
            foreach (var suit in Enum.GetNames(typeof(SuitsEnum)))
            {
                for (int i = 0; i < values.Length; i++)
                {
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
                    deck?.InitialDeck?.Add(card);
                }
                
            }
            return deck;

        }
    }
}
