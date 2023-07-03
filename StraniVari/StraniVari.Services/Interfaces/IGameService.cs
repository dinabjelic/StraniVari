using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IGameService: ICrudService<Game, UpSertGameRequest, UpSertGameRequest, GetGamesResponse>
    {
        /// <summary>
        /// returns list of games
        /// </summary>
        /// <returns></returns>
        Task<List<GetGamesResponse>> GetAllGames();

        /// <summary>
        /// returns filtered games
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        Task<List<Game>> GetFilteredGames(string searchTerm);
    }
}
