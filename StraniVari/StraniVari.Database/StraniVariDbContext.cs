using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Database.DataSeed;

namespace StraniVari.Database
{
    public class StraniVariDbContext : IdentityDbContext<User, IdentityRole<int>, int>
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
        public DbSet<VolunteerTrip> VolunteerTrip { get; set; }
        public DbSet<TripStatus> TripStatuses { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Administrator> Administrators { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(v => v.Volunteer)
                .WithOne(u => u.User)
                .HasForeignKey<Volunteer>(u => u.Id);

            modelBuilder.Entity<User>()
               .HasOne(v => v.Administrator)
               .WithOne(u => u.User)
               .HasForeignKey<Administrator>(u => u.Id);

            modelBuilder.SeedGames();
            modelBuilder.SeedEvent();
            modelBuilder.SeedEventSchool();
            modelBuilder.SeedMaterial();
            modelBuilder.SeedNotifications();
            modelBuilder.SeedPlanAndProgramme();
            modelBuilder.SeedSchoolMaterial();
            modelBuilder.SeedSchools();
            modelBuilder.SeedSchoolVolunteers();
            modelBuilder.SeedUserInformation();
            modelBuilder.SeedVolunteers();
            modelBuilder.SeedAdministrators();
            modelBuilder.SeedRoles();
            modelBuilder.SeedUserRoles();
            modelBuilder.SeedTrips();
            modelBuilder.SeedStatus();
            modelBuilder.SeedVolunteerTrips();
        }
    }
}