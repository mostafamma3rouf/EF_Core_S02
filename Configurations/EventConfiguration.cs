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
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");

            builder.HasKey(E => E.Id);

            builder.Property(E => E.Title);
            builder.Property(E => E.Description);
            builder.Property(E => E.StartDate);
            builder.Property(E => E.EndDate);
            builder.Property(E => E.MaxAttendees);

            builder.HasOne(E => E.Organizer)
                   .WithMany(O => O.Events)
                   .HasForeignKey(E => E.OrganizerId);

        }
    }
}
