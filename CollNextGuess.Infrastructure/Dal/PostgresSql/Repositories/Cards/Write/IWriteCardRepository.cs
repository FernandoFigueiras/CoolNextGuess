using CollNextGuess.Core.Entities;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Write;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.Cards.Write
{
    public interface IWriteCardRepository : IWriteGenericRepository<Card>
    {
    }
}
