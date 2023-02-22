using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Common.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class GamesController : BaseApiController
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> AddGame(UpSertGameRequest addGameRequest)
        {
            await _gameService.AddGameAsync(addGameRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> UpdateGame(int id, [FromBody]UpSertGameRequest updateGameRequest)
        {
            await _gameService.UpdateGameAsync(id,updateGameRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> DeleteGame(int id)
        {
            await _gameService.DeleteGameAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet("with-details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GameListWithDetails()
        {
            return Ok(await _gameService.GameListWithDetailsAsync());
        }

        [HttpGet]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GameList()
        {
            return Ok(await _gameService.GameListAsync());
        }

    }
}
