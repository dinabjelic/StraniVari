using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface ISchoolVolunteerService :I_CrudService<SchoolVolunteer, InsertVolunteerToSchoolRequest, UpdateVolunteerAssignedToSchoolRequest, GetVolunteersForSchoolResponse>
    {
        /// <summary>
        /// adding volunteers for choosen shcool
        /// </summary>
        /// <param name="insertVolunteerToSchoolRequest"></param>
        /// <returns></returns>
        Task Insert(InsertVolunteerToSchoolRequest insertVolunteerToSchoolRequest);
        /// <summary>
        /// getting list of volunteers for school
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetVolunteersForSchoolResponse>> GetById(int id);
    }
}
