using EF_Core_S02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_S02.AppDbContexts
{
    internal class EventHubDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EventHub; Trusted_Connection = true; TrustServerCertificate = true;");
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizerProfile>(entity =>
            {
                entity.HasKey(OP => OP.Id);

                entity.Property(OP => OP.Biography);
                entity.Property(OP => OP.WebsiteUrl);
                entity.Property(OP => OP.LogoPath);

                entity.HasOne(OP => OP.Organizer)
                      .WithOne(O => O.Profile)
                      .HasForeignKey<OrganizerProfile>(OP => OP.OrganizerId);
            });
        }
    }
}
