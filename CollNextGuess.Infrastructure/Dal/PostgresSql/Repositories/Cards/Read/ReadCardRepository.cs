using CollNextGuess.Core.Entities;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Read;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.Cards.Read
{
    public class ReadCardRepository : ReadGenericRepository<Card>, IReadCardRepository
    {
        private readonly DataContext _context;

        public ReadCardRepository(DataContext context) : base(context)
        {
            this._context = context;
        }
    }
}
