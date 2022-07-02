using CollNextGuess.Core.Models.Requests.Classes;
using CollNextGuess.Core.Models.Requests.Interfaces;

namespace CollNextGuess.Api.ServiceExtensions
{
    public static class ServiceConfiguration
    {
        public static void AddModels(this IServiceCollection services)
        {
            services.AddScoped<IGameRegisterModel, GameRegisterModel>();
        }
    }
}
