using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class GameService : BaseCrudService<Game, UpSertGameRequest, GetGamesResponse>, IGameService
    {
        private readonly StraniVariDbContext _straniVariDbContext;

        public GameService(StraniVariDbContext straniVariDbContext, IMapper mapper):base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task<List<GetGamesResponse>> GameListWithDetailsAsync()
        {
            var gameList = await _straniVariDbContext.Games.Select(x => new GetGamesResponse
            {
                Id = x.Id,
                Name = "Name: "+ x.Name+ ", Rules: " + x.Rules + "\n",
            }).ToListAsync();

            return gameList;
        }
    }
}
