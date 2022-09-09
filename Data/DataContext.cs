using IOsonet.Models;
using Microsoft.EntityFrameworkCore;

namespace IOsonet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Posts> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasMany(p => p.Posts);
            modelBuilder.Entity<Profile>().HasMany(f => f.FriendsProfiles);
        }
    }
}
