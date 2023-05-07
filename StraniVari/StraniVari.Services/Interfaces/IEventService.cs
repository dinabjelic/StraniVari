using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IEventService: ICrudService<Event, EventUpsertRequestMapp, GetEventDetailsResponse>
    {
        /// <summary>
        /// showing events only for active year
        /// </summary>
        /// <returns></returns>
        Task<List<GetEventDetailsResponse>> GetEventDetailsActiveYear(int userId);
        /// <summary>
        /// returns the last added Event
        /// </summary>
        /// <returns></returns>
        Task<GetEventDetailsResponse> GetLastAddedEvent();
    }
}
