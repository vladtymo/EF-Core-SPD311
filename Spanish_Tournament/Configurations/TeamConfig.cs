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
    internal class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .HasMany(x => x.Goals)
                .WithOne(x => x.Team)
                .HasForeignKey(x => x.TeamId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
