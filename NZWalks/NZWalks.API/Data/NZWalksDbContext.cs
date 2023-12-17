using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options):base(options)
        {
            
        }
        public DbSet<Walk> Walks{ get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

        public DbSet<Region> Regions { get; set; }

    }
}
