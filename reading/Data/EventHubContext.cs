using Microsoft.EntityFrameworkCore;
using EventHub.Models;

namespace EventHub
{
    public class EventHubContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }

        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Attendee> Attendees { get; set; }

        public DbSet<Badge> Badges { get; set; }

        public EventHubContext(
            DbContextOptions<EventHubContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuration Classes
            modelBuilder.ApplyConfiguration(
                new OrganizerProfileConfiguration());

            modelBuilder.ApplyConfiguration(
                new EventConfiguration());

            // Badge Configuration - Direct Fluent API

            modelBuilder.Entity<Badge>(entity =>
            {
                entity.HasKey(b => b.BadgeId);

                entity.Property(b => b.BadgeNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasIndex(b => b.BadgeNumber)
                    .IsUnique();

                entity.Property(b => b.IssuedDate)
                    .IsRequired();

                entity.Property(b => b.Tier)
                    .HasConversion<string>()
                    .HasMaxLength(20)
                    .IsRequired();

                entity.HasOne(b => b.Attendee)
                    .WithOne(a => a.Badge)
                    .HasForeignKey<Badge>(
                        b => b.AttendeeId)
                    .IsRequired();

                entity.HasIndex(b => b.AttendeeId)
                    .IsUnique();
            });
        }
    }
}
