using CollNextGuess.Core.Entities;
using CollNextGuess.Infrastructure.Dal.PostgresSql.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql
{
    public class DataContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> GamePlays { get; set; }
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new PlayerConfiguration().Configure(builder.Entity<Player>());
            new GamePlayConfiguration().Configure(builder.Entity<GamePlay>());
            base.OnModelCreating(builder);
        }
    }
}
