using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

namespace StraniVari.Database.DataSeed
{
    public static class SchoolMaterialSeed
    {
        public static void SeedSchoolMaterial(this ModelBuilder builder)
        {
            Random random = new Random();

            List<int> quantity = new()
            {
                23,
                20,
                30,
                10, 
                2, 
                6, 
                10
            };

            List<SchoolMaterial> schoolMaterials = new();

            for (int i = 1; i <= 5; i++)
            {
                schoolMaterials.Add(new SchoolMaterial
                {
                    Id= i, 
                    EventSchoolId = random.Next(1, 10),
                    MaterialId = random.Next(1, 19),
                    Quantity = quantity[i % 7]
                });
            }

            var schoolMaterial = schoolMaterials.First();
            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 6,
                EventSchoolId = schoolMaterial.EventSchoolId,
                MaterialId = 20,
                Quantity = 2
            });
            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 7,
                EventSchoolId = 11,
                MaterialId = 20,
                Quantity = 2
            });


            builder.Entity<SchoolMaterial>().HasData(schoolMaterials);
        }
    }
}
