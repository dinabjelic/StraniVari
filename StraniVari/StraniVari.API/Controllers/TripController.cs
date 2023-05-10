﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class TripController : BaseCRUDController<Trip, UpSertTripRequest, UpSertTripRequest, GetTripResponse>
    {
        private readonly ITripService _tripService;
        public TripController(ITripService tripService) : base(tripService)
        {
            _tripService = tripService;
        }

        [HttpGet("details")]
        public override async Task<IActionResult> GetById(int id)
        {
            return Ok(await _tripService.GetById(id));
        }
    }
}