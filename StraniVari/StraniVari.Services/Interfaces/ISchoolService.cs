using StraniVari.Core.Entities;
using StraniVari.Core.Requests;

namespace StraniVari.Services.Interfaces
{
    public interface ISchoolService : ICrudService<School, SchoolUpsertRequest>
    {
    }
}
