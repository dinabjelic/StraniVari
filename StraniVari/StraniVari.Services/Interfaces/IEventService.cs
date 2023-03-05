using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IEventService
    {
        /// <summary>
        /// getting details for choosen event 
        /// </summary>
        /// <returns></returns>
        Task<List<GetEventDetailsResponse>> GetEventDetailsAsync();
        /// <summary>
        /// get event details for choosen school 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetEventDetailsByIdResponse>> GetEventDetailsByIdAsync(int id);
        /// <summary>
        /// Adding event details for school
        /// </summary>
        /// <param name="addEventRequest"></param>
        /// <returns></returns>
        Task AddEventAsync(EventUpsertRequest addEventRequest);
        /// <summary>
        /// updating event details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="addEventRequest"></param>
        /// <returns></returns>
        Task UpdateEventAsync(int id,EventUpsertRequest addEventRequest);
        /// <summary>
        /// deleting event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteEventAsync(int id);
        /// <summary>
        /// showing events only for active year
        /// </summary>
        /// <returns></returns>
        Task<List<GetEventDetailsResponse>> GetEventDetailsActiveYear(int userId);
    }
}
