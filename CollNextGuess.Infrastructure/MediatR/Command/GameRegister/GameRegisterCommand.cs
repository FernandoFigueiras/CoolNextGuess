using CollNextGuess.Core.Models.Requests.Classes;
using CollNextGuess.Infrastructure.Response;
using MediatR;

namespace CollNextGuess.Infrastructure.MediatR.Command.GameRegister
{
    public record GameRegisterCommand(GameRegisterModel model) : IRequest<GenericResponse>;
}
