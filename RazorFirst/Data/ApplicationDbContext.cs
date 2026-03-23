using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RazorFirst.Models;

namespace RazorFirst.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ConfigureWarnings(warnings => 
                warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.HasData(new IdentityRole
                {
                    Id = "00000000-0000-0000-0000-000000000001",
                    Name = "Administrátor",
                    NormalizedName = "Administrátor".ToUpper()
                });
            });
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.HasData(new ApplicationUser
                {
                    Id = "00000000-0000-0000-0001-000000000001",
                    UserName = "admin@x.test",
                    NormalizedUserName = "ADMIN@X.TEST",
                    Email = "admin@x.test",
                    NormalizedEmail = "ADMIN@X.TEST",
                    FirstName = "Admin",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Admin123!"),
                    EmailConfirmed = true
                });
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.HasData(new IdentityUserRole<string>
                {
                    UserId = "00000000-0000-0000-0001-000000000001",
                    RoleId = "00000000-0000-0000-0000-000000000001"
                });
            });
        }
    }
}
