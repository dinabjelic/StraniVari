using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class AdministratorController : BaseCRUDController<Administrator, AdministratorUpSertRequest, AdministratorUpSertRequest, GetAdministratorDetailsResponse>
    {
        private readonly IAdministratorService _administratorService;
        public AdministratorController(IAdministratorService administratorService) : base(administratorService)
        {
            _administratorService = administratorService;
        }

        [HttpGet("filtered-data")]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> GetFilteredEvents(string? searchTerm)
        {
            return Ok(await _administratorService.GetFilteredUsers(searchTerm));
        }
    }
}
