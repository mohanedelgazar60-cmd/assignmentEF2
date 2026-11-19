using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EventHub.Data
{
    public class EventHubContextFactory
        : IDesignTimeDbContextFactory<EventHubContext>
    {
        public EventHubContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<EventHubContext>();

            options.UseSqlServer(
                @"Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True");

            return new EventHubContext(options.Options);
        }
    }
}
