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
    public class TripService : BaseCrudService<Trip, UpSertTripRequest, GetTripResponse>, ITripService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public TripService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task<List<GetTripsDetailsForEvent>> GetById(int id)
        {
            var tripDetails = await _straniVariDbContext.Trips
                .Where(x => x.EventId == id)
                .Select(x => new GetTripsDetailsForEvent
                {
                   Id = x.Id,
                   Place = x.Place, 
                   TripDateTime = x.TripDateTime
                }).ToListAsync();

            return tripDetails;
        }
    }
}
