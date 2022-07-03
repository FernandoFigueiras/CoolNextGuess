using CollNextGuess.Core.Entities;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GamePlays.Read
{
    public class ReadGamePlayRepository : ReadGenericRepository<GamePlay>, IReadGamePlayRepository
    {
        private readonly DataContext _context;

        public ReadGamePlayRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
