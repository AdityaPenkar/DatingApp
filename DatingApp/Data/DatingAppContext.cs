using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DatingApp.Data;
using DatingAppFSDProject.Domain;

namespace DatingApp.Data
{
    public class DatingAppContext(DbContextOptions<DatingAppContext> options) : IdentityDbContext<DatingAppUser>(options)
    {
		public DbSet<DatingAppFSDProject.Domain.Message> Message { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Notification> Notification { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Profile> Profile { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Report> Report { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Setting> Setting { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.ConnectionRequest> ConnectionRequests { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DatingAppUser>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}

