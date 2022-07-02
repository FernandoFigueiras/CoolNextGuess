using CollNextGuess.Core.Models.Requests.Classes;
using CollNextGuess.Core.Models.Requests.Interfaces;
using CollNextGuess.Infrastructure.MediatR.Command.GameRegister;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CollNextGuess.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamePlayController : Controller
    {
        private readonly IMediator _mediator;
        private readonly INewGameModel _gameRegisterModel;

        public GamePlayController(IMediator mediator,
            INewGameModel gameRegisterModel)
        {
            _mediator = mediator;
            this._gameRegisterModel = gameRegisterModel;
        }

        /// <summary>
        /// Used to pass the model necessary for the UI
        /// </summary>
        /// <returns>Enter number of players to start a new game</returns>
        [HttpGet]
        public INewGameModel CreateNewGame()
        {
            return this._gameRegisterModel;
        }

        /// <summary>
        /// Initializes the game
        /// </summary>
        /// <param name="model">model with player name and number of players</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateNewGame([FromBody]NewGameModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var command = new GameRegisterCommand(model);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
