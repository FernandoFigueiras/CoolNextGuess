using CollNextGuess.Core.Entities;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Write;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GamePlays.Write
{
    public class WriteGamePlayRepository : WriteGenericRepository<GamePlay>, IWriteGamePlayRepository
    {
        private readonly DataContext _context;

        public WriteGamePlayRepository(DataContext context) : base(context)
        {
            this._context = context;
        }
    }
}
