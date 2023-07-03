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
    public class GameService : BaseCrudService<Game, UpSertGameRequest, UpSertGameRequest, GetGamesResponse>, IGameService
    {
        private readonly StraniVariDbContext _straniVariDbContext;

        public GameService(StraniVariDbContext straniVariDbContext, IMapper mapper):base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public override async Task<List<GetGamesResponse>> GetAll()
        {
            var gameList = await _straniVariDbContext.Games.Select(x => new GetGamesResponse
            {
                Id = x.Id,
                Name = "Name: "+ x.Name+ ", Rules: " + x.Rules + "\n",
            }).ToListAsync();

            return gameList;
        }

        public async Task<List<GetGamesResponse>> GetAllGames()
        {
            var gameList = await _straniVariDbContext.Games.Select(x => new GetGamesResponse
            {
                Id = x.Id,
                Name = x.Name, 
                Rules = x.Rules
            }).ToListAsync();

            return gameList;
        }

        public async Task<List<Game>> GetFilteredGames(string searchTerm)
        {
            var filteredData = await _straniVariDbContext.Games.ToListAsync();   

            if(!string.IsNullOrWhiteSpace(searchTerm))
            {
                filteredData = filteredData.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower())).ToList();
            }

            return filteredData;
        }
    }
}
