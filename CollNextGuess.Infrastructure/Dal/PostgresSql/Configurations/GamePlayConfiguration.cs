using CollNextGuess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Configurations
{
    public class GamePlayConfiguration : IEntityTypeConfiguration<GamePlay>
    {
        public void Configure(EntityTypeBuilder<GamePlay> playerBuilder)
        {
            playerBuilder.Property(gamePlay => gamePlay.GetType())
                .IsRequired()
                .HasMaxLength(10);
            playerBuilder.Property(gamePlay => gamePlay.NumberOfPlayers)
                .IsRequired()
                .HasMaxLength(4);
        }
    }
}
