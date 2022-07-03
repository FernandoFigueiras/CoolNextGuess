using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollNextGuess.Core.Entities
{
    public class InGameCardDeck : IEntity
    {
        public int Id { get; set; }

        public List<Card>? GameDeck { get; set; } = new List<Card>();
    }
}
