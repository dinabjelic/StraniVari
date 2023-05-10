using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IGameService: ICrudService<Game, UpSertGameRequest, UpSertGameRequest, GetGamesResponse>
    {
        /// <summary>
        /// getting names and rules in one
        /// </summary>
        /// <returns></returns>
        Task<List<GetGamesResponse>> GameListWithDetailsAsync();
    }
}
