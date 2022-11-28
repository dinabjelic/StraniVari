using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class StraniVariThemeService : IStraniVariThemeService
    {
        private readonly StraniVariDbContext _straniVariDbContext;

        public StraniVariThemeService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }
        public async Task AddStraniVariThemeAsync(UpSertStraniVariThemesRequest addStraniVariThemeRequest)
        {
            var newTheme = new StraniVariTheme
            {
                Theme= addStraniVariThemeRequest.Theme, 
                VolunteeringYear= addStraniVariThemeRequest.VolunteeringYear
            };

            await _straniVariDbContext.StraniVariThemes.AddAsync(newTheme);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task DeleteStraniVariThemeAsync(int id)
        {
            var themeFound = await _straniVariDbContext.StraniVariThemes.FirstOrDefaultAsync(x => x.Id == id);

            if (themeFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.StraniVariThemes.Remove(themeFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetStraniVariThemesResponse>> StraniVariThemesListAsync()
        {
            var straniVariThemesList = await _straniVariDbContext.StraniVariThemes.Select(x => new GetStraniVariThemesResponse
            {
                Theme = x.Theme,
                VolunteeringYear = x.VolunteeringYear
            }).ToListAsync();

            return straniVariThemesList;
        }

        public async Task UpdateStraniVariThemeAsync(int id, UpSertStraniVariThemesRequest updateStraniVariThemeRequest)
        {
            if (updateStraniVariThemeRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var themeFound = await _straniVariDbContext.StraniVariThemes.FirstOrDefaultAsync(x => x.Id == id);

            if (themeFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            themeFound.Theme = updateStraniVariThemeRequest.Theme;
            themeFound.VolunteeringYear = updateStraniVariThemeRequest.VolunteeringYear;

            _straniVariDbContext.StraniVariThemes.Update(themeFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
