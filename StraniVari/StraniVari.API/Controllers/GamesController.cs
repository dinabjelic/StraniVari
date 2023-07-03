using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class GamesController : BaseCRUDController<Game, UpSertGameRequest, UpSertGameRequest,GetGamesResponse>
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService):base(gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("with-details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _gameService.GetAll());
        }

        [HttpGet("games")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetAllGames()
        {
            return Ok(await _gameService.GetAllGames());
        }

        [HttpGet("filtered-data")]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> GetFilteredEvents(string? searchTerm)
        {
            return Ok(await _gameService.GetFilteredGames(searchTerm));
        }
    }
}
