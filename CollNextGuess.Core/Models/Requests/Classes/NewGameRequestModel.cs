using CollNextGuess.Core.Models.Requests.Interfaces;

namespace CollNextGuess.Core.Models.Requests.Classes
{
    public class NewGameRequestModel : INewGameRequestModel
    {
        public int NumberOfPlayers { get; set; } = 1;
        public string? PlayerOneName { get; set; }
        public string? PlayerTwoName { get; set; }
        public string? PlayerThreeName { get; set; }
        public string? PlayerFourName { get; set; }
    }
}
