using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class GamesController : BaseCRUDController<Game, UpSertGameRequest, GetGamesResponse>
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService):base(gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("with-details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GameListWithDetails()
        {
            return Ok(await _gameService.GameListWithDetailsAsync());
        }
    }
}
