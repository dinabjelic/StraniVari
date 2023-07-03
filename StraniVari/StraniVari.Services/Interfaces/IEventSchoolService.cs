using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IEventSchoolService: ICrudService<EventSchool, EventSchoolInsertRequest, EventSchoolUpdateRequest, GetSchoolsForEventResponse>
    {
        /// <summary>
        /// getting 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetSchoolsForEventResponse>> GetSchoolsForEvent(int id);

        /// <summary>
        /// getting schools that are not added on event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetAvailableSchoolsForEventResponse>> GetAvailableSchools(int id);
    }
}
