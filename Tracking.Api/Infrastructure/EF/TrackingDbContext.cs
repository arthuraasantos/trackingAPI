using Microsoft.EntityFrameworkCore;
using Tracking.Api.Domain.Campaigns;
using Tracking.Api.Domain.Events;

namespace Tracking.Api.Infrastructure.EF
{
    public class TrackingDbContext: DbContext
    {
        public TrackingDbContext(DbContextOptions<TrackingDbContext> options)
            : base(options)
        { }
        public TrackingDbContext()
        {
            
        }

        public DbSet<Campaign> Campaigns { get; set; }

        public DbSet<Event> Events { get; set; }

    }
}
