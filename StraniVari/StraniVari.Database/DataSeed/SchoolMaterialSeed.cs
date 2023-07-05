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
            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 1,
                EventSchoolId = 1,
                MaterialId = 20,
                Quantity = 20
            });
            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 2,
                EventSchoolId = 2,
                MaterialId = 19,
                Quantity = 30
            });

            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 3,
                EventSchoolId = 3,
                MaterialId = 20,
                Quantity = 20
            });
            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 4,
                EventSchoolId = 4,
                MaterialId = 17,
                Quantity = 20
            });

            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 5,
                EventSchoolId = 5,
                MaterialId = 16,
                Quantity = 20
            });
            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 6,
                EventSchoolId = 6,
                MaterialId = 15,
                Quantity = 20
            });

            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 7,
                EventSchoolId = 7,
                MaterialId = 15,
                Quantity = 20
            });
            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 8,
                EventSchoolId = 8,
                MaterialId = 12,
                Quantity = 31
            });

            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 9,
                EventSchoolId = 9,
                MaterialId = 10,
                Quantity = 31
            });
            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 10,
                EventSchoolId = 10,
                MaterialId = 7,
                Quantity = 31
            });

            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 11,
                EventSchoolId = 11,
                MaterialId = 6,
                Quantity = 31
            });
            schoolMaterials.Add(new SchoolMaterial
            {
                Id = 12,
                EventSchoolId = 12,
                MaterialId = 8,
                Quantity = 31
            });

            builder.Entity<SchoolMaterial>().HasData(schoolMaterials);
        }
    }
}
