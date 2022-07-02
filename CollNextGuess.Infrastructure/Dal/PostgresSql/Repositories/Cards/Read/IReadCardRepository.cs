using CollNextGuess.Core.Entities;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.GenericRepo.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Repositories.Cards.Read
{
    public interface IReadCardRepository : IReadGenericRepository<Card>
    {
    }
}
