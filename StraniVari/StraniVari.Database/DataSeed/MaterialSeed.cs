using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

namespace StraniVari.Database.DataSeed
{
    public static class MaterialSeed
    {
        public static void SeedMaterial(this ModelBuilder builder)
        {
            List<string> materialNames = new()
            {
                "Tempere",
                "Vodene bojice",
                "Papir u boji",
                "Lopte",
                "Reketi",
                "Flomasteri",
                "Bojice",
                "Hamer papir",
                "Face paint",
                "Glina",
                "Plastelin",
                "Siljalo",
                "Makaze",
                "Kolaz papir",
                "Platno",
                "Bijeli papir",
                "Krede",
                "Heftarica",
                "Baloni",
                "Hemijske olovke"
            };

            List<Material> materials = new();

            for(int i =1; i<=20; i++)
            {
                materials.Add(new Material
                {
                    Id=i, 
                    Name = materialNames[i % 20]
                });
            }
            builder.Entity<Material>().HasData(materials);
        }
    }
}
