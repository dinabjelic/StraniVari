using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class SchoolsController : BaseCRUDController<School, SchoolUpsertRequest, GetSchoolDetailsResponse>
    {
        public SchoolsController(ISchoolService schoolService):base(schoolService)
        {
        }
    }
}
