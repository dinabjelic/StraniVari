using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;

namespace StraniVari.Database.DataSeed
{
    public static class PlanAndProgrammeSeed
    {
        public static void SeedPlanAndProgramme(this ModelBuilder builder)
        {
            Random random = new Random();

            List<string> activities = new()
            {
                "Bans",
                "Radionice",
                "Pauza",
                "Sekcije"
            };

            List<PlanAndProgramme> planAndProgramme = new();
            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);

            for (int i = 1; i <= 5; i++)
            {
                planAndProgramme.Add(new PlanAndProgramme
                {
                    Id=i, 
                    EventId = random.Next(1,5),
                    Activity = activities[i % 4],
                    StartDate = DateGenerator.GenerateRandomDate(startDate, endDate), 
                    EndDate = DateGenerator.GenerateRandomDate(startDate, endDate)
                });
            }
            builder.Entity<PlanAndProgramme>().HasData(planAndProgramme);
        }
    }
}
