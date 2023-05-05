using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class TripController : BaseCRUDController<Trip, UpSertTripRequest, GetTripResponse>
    {
        public TripController(ITripService tripService) : base(tripService)
        {
        }
    }
}
