using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Database.DataSeed;

namespace StraniVari.Database
{
    public class StraniVariDbContext:IdentityDbContext<User, IdentityRole<int>, int>
    {

        public StraniVariDbContext(DbContextOptions<StraniVariDbContext> options)
         : base(options)
        {
        }
        public DbSet<School> Schools { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlanAndProgramme> PlanAndProgramme { get; set; }
        public DbSet<SchoolMaterial> SchoolMaterials { get; set; }
        public DbSet<SchoolVolunteer> SchoolVolunteers { get; set; }
        public DbSet<EventSchool> EventSchools { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedGames();
            modelBuilder.SeedEvent();
            modelBuilder.SeedEventSchool();
            modelBuilder.SeedMaterial();
            modelBuilder.SeedNotifications();
            modelBuilder.SeedPlanAndProgramme();
            modelBuilder.SeedSchoolMaterial();
            modelBuilder.SeedSchools();
            modelBuilder.SeedSchoolVolunteers();
            modelBuilder.SeedVolunteers();
            modelBuilder.SeedUserInformation();
            modelBuilder.SeedRoles();
            modelBuilder.SeedUserRoles();
        }
    }
}