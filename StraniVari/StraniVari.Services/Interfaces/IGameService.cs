using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IGameService: ICrudService<Game, UpSertGameRequest, UpSertGameRequest, GetGamesResponse>
    {
        Task<List<GetGamesResponse>> GetAllGames();
    }
}
