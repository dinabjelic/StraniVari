using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class GameService : IGameService
    {
        private readonly StraniVariDbContext _straniVariDbContext;

        public GameService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }
        public async Task AddGameAsync(UpSertGameRequest addGameRequest)
        {
            var newGame = new Game
            {
                Name = addGameRequest.Name,
                Rules = addGameRequest.Rules
            };

            await _straniVariDbContext.Games.AddAsync(newGame);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task DeleteGameAsync(int id)
        {
            var materialFound = await _straniVariDbContext.Games.FirstOrDefaultAsync(x => x.Id == id);

            if (materialFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.Games.Remove(materialFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetGamesResponse>> GameListAsync()
        {
            var gameList = await _straniVariDbContext.Games.Select(x => new GetGamesResponse
            {
                Name = x.Name,
                Rules = x.Rules
            }).ToListAsync();

            return gameList;
        }

        public async Task UpdateGameAsync(int id,UpSertGameRequest updateGameRequest)
        {
            if (updateGameRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var gameFound = await _straniVariDbContext.Games.FirstOrDefaultAsync(x => x.Id == id);

            if (gameFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            gameFound.Name = updateGameRequest.Name;
            gameFound.Rules = updateGameRequest.Rules;

            _straniVariDbContext.Games.Update(gameFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
