using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> AddGame(UpSertGameRequest addGameRequest)
        {
            await _gameService.AddGameAsync(addGameRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGame(int id, [FromBody]UpSertGameRequest updateGameRequest)
        {
            await _gameService.UpdateGameAsync(id,updateGameRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGame(int id)
        {
            await _gameService.DeleteGameAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet("with-details")]
        public async Task<IActionResult> GameListWithDetails()
        {
            return Ok(await _gameService.GameListWithDetailsAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GameList()
        {
            return Ok(await _gameService.GameListAsync());
        }

    }
}
