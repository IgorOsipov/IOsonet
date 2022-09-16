using IOsonet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IOsonet.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Posts> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profile>().HasMany(p => p.Posts);

            modelBuilder.Entity<FriendShip>()
            .HasKey(k => new { k.PrimaryProfileId, k.FriendProfileId });

            modelBuilder.Entity<FriendShip>()
                .HasOne(x => x.PrimaryProfile)
                .WithMany(f => f.Friends)
                .HasForeignKey(x => x.PrimaryProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FriendShip>()
                .HasOne(x => x.FriendProfile)
                .WithMany(f => f.FriendsOf)
                .HasForeignKey(x => x.FriendProfileId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
