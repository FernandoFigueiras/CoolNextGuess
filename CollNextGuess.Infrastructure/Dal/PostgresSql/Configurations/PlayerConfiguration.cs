using CollNextGuess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollNextGuess.Infrastructure.Dal.PostgresSql.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> playerBuilder)
        {
            playerBuilder.Property(player => player.Name)
                .HasMaxLength(50);
        }
    }
}
