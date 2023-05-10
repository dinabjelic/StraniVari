using AutoMapper;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class SchoolService : BaseCrudService<School, SchoolUpsertRequest,SchoolUpsertRequest, GetSchoolDetailsResponse>, ISchoolService
    {
        public SchoolService(StraniVariDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
