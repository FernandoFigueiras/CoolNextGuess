namespace CollNextGuess.Core.Models.Requests.Interfaces
{
    public interface INewGameRequestModel
    {
        int NumberOfPlayers { get; set; }
        string? PlayerOneName { get; set; }
        string? PlayerTwoName { get; set; }
        string? PlayerThreeName { get; set; }
        string? PlayerFourName { get; set; }
    }
}
