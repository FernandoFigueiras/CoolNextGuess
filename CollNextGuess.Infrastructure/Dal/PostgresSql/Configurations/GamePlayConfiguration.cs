using CollNextGuess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Configurations
{
    public class GamePlayConfiguration : IEntityTypeConfiguration<GamePlay>
    {
        public void Configure(EntityTypeBuilder<GamePlay> gamePlayBuilder)
        {
            gamePlayBuilder.Property(gamePlay => gamePlay.NumberOfPlayers)
                .IsRequired()
                .HasMaxLength(4);
            gamePlayBuilder.Ignore(gamePlayBuilder => gamePlayBuilder.GameCard);
        }
    }
}
