using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class VolunteersController : BaseCRUDController<Volunteer, VolunteerUpSertRequest, VolunteerUpSertRequest, GetVolunteerDetailsResposne>
    {
        public VolunteersController(IVolunteerService volunteerService):base(volunteerService)
        {
        }
    }
}
