using CollNextGuess.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollNextGuess.Core.Interfaces
{
    public interface IDeckManager
    {
        InGameCardDeck GetInGameCardDeck(Card cardGame);


        public Card SetCardGame(List<Card> cards);

    }
}
