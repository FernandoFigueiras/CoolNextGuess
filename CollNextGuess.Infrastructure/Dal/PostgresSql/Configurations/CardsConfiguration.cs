using CollNextGuess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Configurations
{
    internal class CardsConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> cartBuilder)
        {
            cartBuilder.Property(card => card.Suit)
                .IsRequired()
                .HasMaxLength(20);
            cartBuilder.HasNoKey();
        }
    }
}
