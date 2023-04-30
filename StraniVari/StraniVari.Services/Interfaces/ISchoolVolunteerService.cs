using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface ISchoolVolunteerService : ICrudService<SchoolVolunteer, UpdateVolunteerAssignedToSchoolRequest, GetVolunteersForSchoolResponse>
    {
        /// <summary>
        /// adding volunteers for choosen shcool
        /// </summary>
        /// <param name="insertVolunteerToSchoolRequest"></param>
        /// <returns></returns>
        Task AddVolunteerToSchoolAsync(InsertVolunteerToSchoolRequest insertVolunteerToSchoolRequest);
        /// <summary>
        /// getting list of volunteers for school
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetVolunteersForSchoolResponse>> SchoolVolunteerListAsync(int id);
        ///// <summary>
        ///// updating volunteering details
        ///// </summary>
        ///// <param name="updateVolunteerAssignedToSchoolRequest"></param>
        ///// <returns></returns>
        //Task UpdateVolunteerDetailsAsync(UpdateVolunteerAssignedToSchoolRequest updateVolunteerAssignedToSchoolRequest);
        ///// <summary>
        ///// deleting volunteer from school
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //Task DeleteVolunteerFromSchoolAsync(int id);
    }
}
