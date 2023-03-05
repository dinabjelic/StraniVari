using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IEventSchoolService
    {
        /// <summary>
        /// adding schools to choosen event
        /// </summary>
        /// <param name="addEventSchoolUpSertRequest"></param>
        /// <returns></returns>
        Task AddSchoolToEventAsync(EventSchoolInsertRequest addEventSchoolInsertRequest);
        /// <summary>
        /// getting 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetSchoolsForEventResponse>> SchoolsForEventListAsync(int id);
        /// <summary>
        /// getting details for choosen event and school
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<List<GetEventSchoolDetailsResponse>> EventSchoolDetailsAsync(int id);
        /// <summary>
        /// update number of children for school
        /// </summary>
        /// <param name="eventSchoolUpdateRequest"></param>
        /// <returns></returns>
        Task UpdateSchoolForEventAsync(EventSchoolUpdateRequest eventSchoolUpdateRequest);
        /// <summary>
        /// deleting school of that event
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="schoolId"></param>
        /// <returns></returns>
        Task DeleteSchoolForEventAsync(int id);
    }
}
