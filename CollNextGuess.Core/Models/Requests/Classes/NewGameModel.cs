using CollNextGuess.Core.Models.Requests.Interfaces;

namespace CollNextGuess.Core.Models.Requests.Classes
{
    public class NewGameModel : INewGameModel
    {
        public int NumberOfPLayers { get; set; }
    }
}
