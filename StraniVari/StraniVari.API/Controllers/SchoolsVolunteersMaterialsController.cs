using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolsVolunteersMaterialsController : BaseCRUDController<EventSchool, SchoolVolunteerMaterialRequest, SchoolVolunteerMaterialRequest, SchoolVolunteerMaterialRequest>
    {
        public SchoolsVolunteersMaterialsController(ISchoolsVolunteersMaterialsService  schoolsVolunteersMaterialsService) : base(schoolsVolunteersMaterialsService)
        {
        }
    }
}
