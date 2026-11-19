
using EventHub;
using EventHub;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<EventHubContext>()
    .UseSqlServer(
        @"Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True")
    .Options;

using var context = new EventHubContext(options);

Console.WriteLine("EventHub is Ready!");
