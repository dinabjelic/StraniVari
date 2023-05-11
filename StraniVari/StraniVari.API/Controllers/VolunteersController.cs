using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class VolunteersController : BaseCRUDController<Volunteer, VolunteerUpSertRequest, VolunteerUpSertRequest, GetVolunteerDetailsResposne>
    {
        private readonly IVolunteerService _volunteerService;
        public VolunteersController(IVolunteerService volunteerService):base(volunteerService)
        {
            _volunteerService = volunteerService;
        }
    }
}
