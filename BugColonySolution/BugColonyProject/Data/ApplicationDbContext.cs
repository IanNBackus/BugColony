using BugColonyProject.Models.GroupsAndUsers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace BugColonyProject.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<Group> Group { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Members)
                .WithMany(e => e.Groups)
                .UsingEntity<GroupMembership>();

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Invites)
                .WithMany(e => e.Invites)
                .UsingEntity<GroupInvite>();


        }

    }
}
