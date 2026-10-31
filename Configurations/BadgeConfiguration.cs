using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_S02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core_S02.Configurations
{
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(B => B.Id);

            builder.Property(B => B.BadgeNumber);
            builder.Property(B => B.IssuedAt);
            builder.Property(B => B.Tier);

            builder.HasOne(B => B.Attendee)
                   .WithOne(A => A.Badge)
                   .HasForeignKey<Badge>(B => B.AttendeeId);

        }
    }
}
