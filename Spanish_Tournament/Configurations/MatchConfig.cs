using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spanish_Tournament.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Spanish_Tournament.Configurations
{
    internal class MatchConfig : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder
                .HasOne(x => x.HomeTeam)
                .WithMany(x => x.HomeMatches)
                .HasForeignKey(x => x.HomeTeamId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(x => x.GuestTeam)
                .WithMany(x => x.GuestMatches)
                .HasForeignKey(x => x.GuestTeamId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(x => x.Goals)
                .WithOne(x => x.Match)
                .HasForeignKey(x => x.MatchId);
        }
    }
}
