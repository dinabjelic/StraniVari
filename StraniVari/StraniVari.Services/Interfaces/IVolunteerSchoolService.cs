using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IVolunteerSchoolService
    {
        /// <summary>
        /// getting volunteer school list
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        Task<List<GetVolunteerShoolDetailsResponse>> VolunteerSchoolListAsync(int year);
        /// <summary>
        /// getting volunteers list for choosen school
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        Task<List<GetVolunteerShoolDetailsResponse>> GetVoluntersListForChoosenSchoolAsync(int id, int year);
        /// <summary>
        /// getting schools that are assigned to choosen volunteer
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        Task<List<GetSchoolsAssignedDetailsResponse>> GetSchoolsAssignedToVolunteerAsync(int id, int year);
        /// <summary>
        /// adding volunteer to school
        /// </summary>
        /// <param name="addVolunteersToSchool"></param>
        /// <returns></returns>
        Task AddVolunteersToSchoolAsync(VolunteerSchoolUpSertRequest addVolunteersToSchool);
        /// <summary>
        /// removing volunteers from school 
        /// </summary>
        /// <param name="volunteerSchoolDeleteRequest"></param>
        /// <returns></returns>
        Task RemoveVolunteersFromSchoolAsync(VolunteerSchoolDeleteRequest volunteerSchoolDeleteRequest);
    }
}
