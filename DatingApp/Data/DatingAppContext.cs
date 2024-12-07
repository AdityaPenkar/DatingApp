using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DatingApp.Data;

namespace DatingApp.Data
{
    public class DatingAppContext(DbContextOptions<DatingAppContext> options) : IdentityDbContext<DatingAppUser>(options)
    {
		public DbSet<DatingAppFSDProject.Domain.Admin> Admin { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Match> Match { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Message> Message { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.MessageBox> MessageBox { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Notification> Notification { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Profile> Profile { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Report> Report { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.Setting> Setting { get; set; } = default!;
		public DbSet<DatingAppFSDProject.Domain.User> User { get; set; } = default!;
	}
}
