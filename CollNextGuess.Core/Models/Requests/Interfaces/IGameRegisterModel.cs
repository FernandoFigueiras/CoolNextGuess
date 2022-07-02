namespace CollNextGuess.Core.Models.Requests.Interfaces
{
    public interface IGameRegisterModel
    {
        string PlayerName { get; set; }

        int NumberOfPLayers { get; set; }
    }
}
