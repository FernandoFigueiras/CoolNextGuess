using CollNextGuess.Core.Entities;
using CollNextGuess.Core.Models.Responses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollNextGuess.Core.Models.Responses.Classes
{
    public class NewGameResponseModel : INewGameResponseModel
    {
        public string IsMultiPlayer { get; set; }
        public string NumberOfPlayers { get; set; }
        public string GameIsActive { get; set; }
        public Card CardOnTable { get; set; }
        public string CardLeftInDeck { get; set; }
        public Player ActivePlayer { get; set; }
        public string CurrentRound { get; set; }
    }
}
