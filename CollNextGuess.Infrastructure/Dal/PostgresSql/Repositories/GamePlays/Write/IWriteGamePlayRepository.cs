using CollNextGuess.Core.Entities;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Write;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GamePlays.Write
{
    public interface IWriteGamePlayRepository : IWriteGenericRepository<GamePlay>
    {
    }
}
