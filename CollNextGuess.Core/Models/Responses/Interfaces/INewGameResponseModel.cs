using CollNextGuess.Core.Entities;

namespace CollNextGuess.Core.Models.Responses.Interfaces
{
    public interface INewGameResponseModel
    {
        string IsMultiPlayer { get; set; }

        string NumberOfPlayers { get; set; }

        string GameIsActive { get; set; }

        Card CardOnTable { get; set; }

        string CardLeftInDeck { get; set; }

        Player ActivePlayer { get; set; }

        string CurrentRound { get; set; }
    }
}
