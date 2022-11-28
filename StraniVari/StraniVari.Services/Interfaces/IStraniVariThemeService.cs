using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IStraniVariThemeService
    {
        /// <summary>
        /// adding strani vari theme name
        /// </summary>
        /// <param name="addStraniVariThemeRequest"></param>
        /// <returns></returns>
        Task AddStraniVariThemeAsync(UpSertStraniVariThemesRequest addStraniVariThemeRequest);
        /// <summary>
        /// getting strani vari themes
        /// </summary>
        /// <returns></returns>
        Task<List<GetStraniVariThemesResponse>> StraniVariThemesListAsync();
        /// <summary>
        /// updating strani vari theme details
        /// </summary>
        /// <param name="updateStraniVariThemeRequest"></param>
        /// <returns></returns>
        Task UpdateStraniVariThemeAsync(int id, UpSertStraniVariThemesRequest updateStraniVariThemeRequest);
        /// <summary>
        /// deleting strani vari Theme
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteStraniVariThemeAsync(int id);
    }
}
