using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface ISchoolVolunteerService : ICrudService<SchoolVolunteer, InsertVolunteerToSchoolRequest, UpdateVolunteerAssignedToSchoolRequest, GetVolunteersForSchoolResponse>
    {
        /// <summary>
        /// getting list of volunteers for school
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetVolunteersForSchoolResponse>> GetVolunteersForSchool(int id);
        /// <summary>
        /// getting list of volunteers for event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetVolunteersForEventResponse>> GetVolunteersForEvent(int id);
    }
}
