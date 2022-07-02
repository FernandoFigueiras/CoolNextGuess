﻿using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.Cards.Write;
using CollNextGuess.Infrastructure.MediatR.Command.GameRegister;
using CollNextGuess.Infrastructure.Response;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollNextGuess.Infrastructure.MediatR.Handler
{
    public class GameRegisterCommandHandler : IRequestHandler<GameRegisterCommand, GenericResponse>
    {
        private readonly ILogger<GameRegisterCommandHandler> _logger;
        private readonly IWriteCardRepository _writeCardRepository;

        public GameRegisterCommandHandler(ILogger<GameRegisterCommandHandler> logger,
            IWriteCardRepository writeCardRepository)
        {
           _logger = logger;
            this._writeCardRepository = writeCardRepository;
        }

        public async Task<GenericResponse> Handle(GameRegisterCommand request, CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Information, "Handling new game");
            return await Task.FromResult(new GenericResponse());
        }
    }
}
