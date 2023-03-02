using Microsoft.EntityFrameworkCore;
using RoleInStory.Core.Entities;
using RoleInStory.Infrastructure.EntitiesConfigurations;

namespace EntityFrameworkCore
{
    public class RoleInStoryContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public RoleInStoryContext(DbContextOptions<RoleInStoryContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}