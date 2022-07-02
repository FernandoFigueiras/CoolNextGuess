using CollNextGuess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Configurations
{
    internal class CartsConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> cartBuilder)
        {
            cartBuilder.Property(card => card.Suit)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
