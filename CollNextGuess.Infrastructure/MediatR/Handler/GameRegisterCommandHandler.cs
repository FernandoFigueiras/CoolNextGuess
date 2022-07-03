using CollNextGuess.Core.Entities;
using CollNextGuess.Core.Models.Responses.Interfaces;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GamePlays.Write;
using CollNextGuess.Infrastructure.MediatR.Command.GameRegister;
using CollNextGuess.Infrastructure.Response;
using CollNextGuess.Infrastructure.Services.BuildDeckService;
using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CollNextGuess.Infrastructure.MediatR.Handler
{
    public class GameRegisterCommandHandler : IRequestHandler<GameRegisterCommand, GenericResponse>
    {
        private readonly ILogger<GameRegisterCommandHandler> _logger;
        private readonly INewGameResponseModel _newGameResponseModel;
        private readonly IWriteGamePlayRepository _writeGamePlayRepository;

        public GameRegisterCommandHandler(ILogger<GameRegisterCommandHandler> logger,
            INewGameResponseModel newGameResponseModel,
            IWriteGamePlayRepository writeGamePlayRepository)
        {
            _logger = logger;
            this._newGameResponseModel = newGameResponseModel;
            this._writeGamePlayRepository = writeGamePlayRepository;
        }

        public async Task<GenericResponse> Handle(GameRegisterCommand request, CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Information, "Handling new game");
            var response = new GenericResponse();
            if (request.model.NumberOfPlayers.Equals(0))
            {
                response.IsValid = false;
                response.Message = "Number of Players must be between 1 and 4";
            }
            if (request.model.NumberOfPlayers > 4)
            {
                response.IsValid = false;
                response.Message = "Max number of players must be 4";
            }

            try
            {
                List<string> playerNames = new List<string>();
                playerNames.Add(request.model.PlayerOneName);
                playerNames.Add(request.model.PlayerTwoName);
                playerNames.Add(request.model.PlayerThreeName);
                playerNames.Add(request.model.PlayerFourName);
                var GamePlay = new GamePlay(request.model.NumberOfPlayers > 0? request.model.NumberOfPlayers: 1, playerNames);
                GamePlay.DeckAtPlay = JsonConvert.SerializeObject(GamePlay.InGameCardDeck);
                if (GamePlay is null)
                {
                    response.IsValid = false;
                    response.Message = "Could not create GamePLay";
                }
                response.IsValid = true;
                await _writeGamePlayRepository.InsertAsync(GamePlay);
                response.Message = $"Game on, first card is {GamePlay.GameCard.Rank} of {GamePlay.GameCard.Suit} and the first to play is {GamePlay.SetActivePLayer().Name}";
                _newGameResponseModel.CurrentRound = GamePlay.CurrentRound.ToString();
                _newGameResponseModel.IsMultiPlayer = GamePlay.IsMultiPlayer.ToString();
                _newGameResponseModel.NumberOfPlayers = GamePlay.NumberOfPlayers.ToString();
                _newGameResponseModel.GameIsActive = GamePlay.IsActive.ToString();
                _newGameResponseModel.CardOnTable = GamePlay.GameCard;
                _newGameResponseModel.CardLeftInDeck = GamePlay.InGameCardDeck.GameDeck.Count().ToString();
                _newGameResponseModel.ActivePlayer = GamePlay.SetActivePLayer();
                response.Response = _newGameResponseModel;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                response.IsValid = false;
                response.Message = ex.Message;
            }
            return await Task.FromResult(response);
        }
    }
}
