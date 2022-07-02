using CollNextGuess.Core.Models.Requests.Interfaces;

namespace CollNextGuess.Core.Models.Requests.Classes
{
    public class GameRegisterModel : IGameRegisterModel
    {
        public string? PlayerName { get; set; }

        public int NumberOfPLayers { get; set; }

    }
}
