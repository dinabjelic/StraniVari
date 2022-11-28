using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class StraniVariThemesController:BaseApiController
    {
        private readonly IStraniVariThemeService _straniVariThemeService;

        public StraniVariThemesController(IStraniVariThemeService straniVariThemeService)
        {
            _straniVariThemeService = straniVariThemeService;
        }

        [HttpPost]
        public async Task<IActionResult> AddStraniVariTheme(UpSertStraniVariThemesRequest addStraniVariThemeRequest)
        {
            await _straniVariThemeService.AddStraniVariThemeAsync(addStraniVariThemeRequest);
            return Ok("You succeeded");
        }

        [HttpGet]
        public async Task<IActionResult> StraniVariThemesList()
        {
            return Ok(await _straniVariThemeService.StraniVariThemesListAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStraniVariTheme(int id, [FromBody]UpSertStraniVariThemesRequest updateStraniVariThemeRequest)
        {
            await _straniVariThemeService.UpdateStraniVariThemeAsync(id, updateStraniVariThemeRequest);
            return Ok("You succeeded");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStraniVariTheme(int id)
        {
            await _straniVariThemeService.DeleteStraniVariThemeAsync(id);
            return Ok("You succeeded");
        }
    }
}
