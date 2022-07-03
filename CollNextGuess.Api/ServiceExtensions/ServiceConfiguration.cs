using CollNextGuess.Core.Models.Requests.Classes;
using CollNextGuess.Core.Models.Requests.Interfaces;
using CollNextGuess.Core.Models.Responses.Classes;
using CollNextGuess.Core.Models.Responses.Interfaces;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GamePlays.Read;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GamePlays.Write;
using CollNextGuess.Infrastructure.Services.BuildDeckService;

namespace CollNextGuess.Api.ServiceExtensions
{
    public static class ServiceConfiguration
    {
        public static void AddModels(this IServiceCollection services)
        {
            services.AddScoped<INewGameRequestModel, NewGameRequestModel>()
                .AddScoped<INewGameResponseModel, NewGameResponseModel>();
        }

        public static void AddReadRepositories(this IServiceCollection services)
        {
            services.AddScoped<IReadGamePlayRepository, ReadGamePlayRepository>();
        }

        public static void AddWriteRepositories(this IServiceCollection services)
        {
            services.AddScoped<IWriteGamePlayRepository, WriteGamePlayRepository>();
        }

        public static void AddInternalServices(this IServiceCollection services)
        {
            services.AddScoped<IDeckBuilder, DeckBuilder>();
        }
    }
}
