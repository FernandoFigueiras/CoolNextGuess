using CollNextGuess.Core.Models.Requests.Classes;
using CollNextGuess.Core.Models.Requests.Interfaces;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.Cards.Read;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.Cards.Write;

namespace CollNextGuess.Api.ServiceExtensions
{
    public static class ServiceConfiguration
    {
        public static void AddModels(this IServiceCollection services)
        {
            services.AddScoped<INewGameModel, NewGameModel>();
        }

        public static void AddReadRepositories(this IServiceCollection services)
        {
            services.AddScoped<IReadCardRepository, ReadCardRepository>();
        }

        public static void AddWriteRepositories(this IServiceCollection services)
        {
            services.AddScoped<IWriteCardRepository, WriteCardRepository>();
        }
    }
}
