using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IGameService
    {
        /// <summary>
        /// adding game
        /// </summary>
        /// <param name="addGameRequest"></param>
        /// <returns></returns>
        Task AddGameAsync(UpSertGameRequest addGameRequest);
        /// <summary>
        /// updating game details
        /// </summary>
        /// <param name="updateGameRequest"></param>
        /// <returns></returns>
        Task UpdateGameAsync(int id, UpSertGameRequest updateGameRequest);
        /// <summary>
        /// deleting game
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteGameAsync(int id);
        /// <summary>
        /// getting all games from database
        /// </summary>
        /// <returns></returns>
        Task<List<GetGamesResponse>> GameListAsync();
        /// <summary>
        /// getting names and rules in one
        /// </summary>
        /// <returns></returns>
        Task<List<GetGamesResponse>> GameListWithDetailsAsync();
    }
}
