using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;
using StraniVari.Services.Services;
using System.Threading.Tasks;

namespace StraniVari.API.Controllers
{
    public class TripController : BaseCRUDController<Trip, UpSertTripRequest, GetTripResponse>
    {
        private readonly ITripService _tripService;
        public TripController(ITripService tripService) : base(tripService)
        {
            _tripService = tripService;
        }

        [HttpGet("details")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public override async Task<IActionResult> GetById(int id)
        {
            return Ok(await _tripService.GetById(id));
        }
    }
}
