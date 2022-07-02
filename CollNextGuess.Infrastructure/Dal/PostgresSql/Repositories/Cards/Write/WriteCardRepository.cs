using CollNextGuess.Core.Entities;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Write;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.Cards.Write
{
    public class WriteCardRepository : WriteGenericRepository<Card>, IWriteCardRepository
    {
        private readonly DataContext _context;

        public WriteCardRepository(DataContext context) : base(context)
        {
            this._context = context;
        }
    }
}
