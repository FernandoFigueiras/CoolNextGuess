using CollNextGuess.Core.Entities;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Read;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GamePlays.Read
{
    public interface IReadGamePlayRepository : IReadGenericRepository<GamePlay>
    {
    }
}
