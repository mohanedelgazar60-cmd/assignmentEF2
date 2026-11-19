using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EventHub.Models;

namespace EventHub
{
    public class OrganizerProfileConfiguration
        : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(
            EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(p => p.OrganizerProfileId);

            builder.Property(p => p.Biography)
                .HasMaxLength(500);

            builder.Property(p => p.WebsiteUrl)
                .HasMaxLength(250);

            builder.Property(p => p.LogoUrl)
                .HasMaxLength(250);

            // One-to-One
            builder.HasOne(p => p.Organizer)
                .WithOne(o => o.Profile)
                .HasForeignKey<OrganizerProfile>(
                    p => p.OrganizerId)
                .IsRequired();
        }
    }
}


