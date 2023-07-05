using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

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

            var startDate1 = new DateTime(2018, 7, 24, 08, 30, 0); 
            var endDate1 = new DateTime(2018, 7, 24, 09, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 1,
                EventId = 1,
                Activity = "Bans",
                StartDate = startDate1,
                EndDate = endDate1
            });

            var startDate2 = new DateTime(2018, 7, 24, 08, 30, 0); 
            var endDate2 = new DateTime(2018, 7, 24, 09, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 2,
                EventId = 2,
                Activity = "Bans",
                StartDate = startDate2,
                EndDate = endDate2
            });

            var startDate3 = new DateTime(2018, 7, 24, 08, 30, 0);
            var endDate3 = new DateTime(2018, 7, 24, 09, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 3,
                EventId = 3,
                Activity = "Bans",
                StartDate = startDate3,
                EndDate = endDate3
            });


            var startDate4 = new DateTime(2018, 7, 24, 08, 30, 0);
            var endDate4 = new DateTime(2018, 7, 24, 09, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 4,
                EventId = 4,
                Activity = "Bans",
                StartDate = startDate4,
                EndDate = endDate4
            });


            var startDate5 = new DateTime(2018, 7, 24, 08, 30, 0);
            var endDate5 = new DateTime(2018, 7, 24, 09, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 5,
                EventId = 5,
                Activity = "Bans",
                StartDate = startDate5,
                EndDate = endDate5
            });


            var startDate6 = new DateTime(2018, 7, 24, 08, 30, 0);
            var endDate6 = new DateTime(2018, 7, 24, 09, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 6,
                EventId = 6,
                Activity = "Bans",
                StartDate = startDate6,
                EndDate = endDate6
            });



            var startDate7 = new DateTime(2018, 7, 24, 09, 00, 0);
            var endDate7 = new DateTime(2018, 7, 24, 10, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 7,
                EventId = 1,
                Activity = "Radionica",
                StartDate = startDate7,
                EndDate = endDate7
            });

            var startDate8 = new DateTime(2018, 7, 24, 09, 00, 0);
            var endDate8 = new DateTime(2018, 7, 24, 10, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 8,
                EventId = 2,
                Activity = "Radionica",
                StartDate = startDate8,
                EndDate = endDate8
            });

            var startDate9 = new DateTime(2018, 7, 24, 09, 00, 0);
            var endDate9 = new DateTime(2018, 7, 24, 10, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 9,
                EventId = 3,
                Activity = "Radionica",
                StartDate = startDate9,
                EndDate = endDate9
            });


            var startDate10 = new DateTime(2018, 7, 24, 09, 00, 0);
            var endDate10 = new DateTime(2018, 7, 24, 10, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 10,
                EventId = 4,
                Activity = "Radionica",
                StartDate = startDate10,
                EndDate = endDate10
            });


            var startDate11 = new DateTime(2018, 7, 24, 09, 00, 0);
            var endDate11 = new DateTime(2018, 7, 24, 10, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 11,
                EventId = 5,
                Activity = "Radionica",
                StartDate = startDate11,
                EndDate = endDate11
            });


            var startDate12 = new DateTime(2018, 7, 24, 09, 00, 0);
            var endDate12 = new DateTime(2018, 7, 24, 10, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 12,
                EventId = 6,
                Activity = "Radionica",
                StartDate = startDate12,
                EndDate = endDate12
            });


            var startDate13 = new DateTime(2018, 7, 24, 11, 00, 0);
            var endDate13 = new DateTime(2018, 7, 24, 12, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 13,
                EventId = 1,
                Activity = "Pauza",
                StartDate = startDate13,
                EndDate = endDate13
            });

            var startDate14 = new DateTime(2018, 7, 24, 11, 00, 0);
            var endDate14 = new DateTime(2018, 7, 24, 12, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 14,
                EventId = 2,
                Activity = "Pauza",
                StartDate = startDate14,
                EndDate = endDate14
            });

            var startDate15 = new DateTime(2018, 7, 24, 11, 00, 0);
            var endDate15 = new DateTime(2018, 7, 24, 12, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 15,
                EventId = 3,
                Activity = "Pauza",
                StartDate = startDate15,
                EndDate = endDate15
            });


            var startDate16 = new DateTime(2018, 7, 24, 11, 00, 0);
            var endDate16 = new DateTime(2018, 7, 24, 12, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 16,
                EventId = 4,
                Activity = "Pauza",
                StartDate = startDate16,
                EndDate = endDate16
            });


            var startDate17 = new DateTime(2018, 7, 24, 11, 00, 0);
            var endDate17 = new DateTime(2018, 7, 24, 12, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 17,
                EventId = 5,
                Activity = "Pauza",
                StartDate = startDate17,
                EndDate = endDate17
            });


            var startDate18 = new DateTime(2018, 7, 24, 11, 00, 0);
            var endDate18 = new DateTime(2018, 7, 24, 12, 00, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 18,
                EventId = 6,
                Activity = "Pauza",
                StartDate = startDate18,
                EndDate = endDate18
            });


            var startDate19 = new DateTime(2018, 7, 24, 12, 00, 0);
            var endDate19 = new DateTime(2018, 7, 24, 13, 30, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 19,
                EventId = 1,
                Activity = "Sekcije",
                StartDate = startDate19,
                EndDate = endDate19
            });

            var startDate20 = new DateTime(2018, 7, 24, 12, 00, 0);
            var endDate20 = new DateTime(2018, 7, 24, 13, 30, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 20,
                EventId = 2,
                Activity = "Sekcije",
                StartDate = startDate20,
                EndDate = endDate20
            });

            var startDate21 = new DateTime(2018, 7, 24, 12, 00, 0);
            var endDate21 = new DateTime(2018, 7, 24, 13, 30, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 21,
                EventId = 3,
                Activity = "Sekcije",
                StartDate = startDate21,
                EndDate = endDate21
            });


            var startDate22 = new DateTime(2018, 7, 24, 12, 00, 0);
            var endDate22 = new DateTime(2018, 7, 24, 13, 30, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 22,
                EventId = 4,
                Activity = "Sekcije",
                StartDate = startDate22,
                EndDate = endDate22
            });


            var startDate23 = new DateTime(2018, 7, 24, 12, 00, 0);
            var endDate23 = new DateTime(2018, 7, 24, 13, 30, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 23,
                EventId = 5,
                Activity = "Sekcije",
                StartDate = startDate23,
                EndDate = endDate23
            });


            var startDate24 = new DateTime(2018, 7, 24, 12, 00, 0);
            var endDate24 = new DateTime(2018, 7, 24, 13, 30, 0);
            planAndProgramme.Add(new PlanAndProgramme
            {
                Id = 24,
                EventId = 6,
                Activity = "Sekcije",
                StartDate = startDate24,
                EndDate = endDate24
            });

            builder.Entity<PlanAndProgramme>().HasData(planAndProgramme);
        }
    }
}
