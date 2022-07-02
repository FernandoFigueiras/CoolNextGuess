using CollNextGuess.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql
{
    public class DataContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Player> Players { get; set; }

        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
