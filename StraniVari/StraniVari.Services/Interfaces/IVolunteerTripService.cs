using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IVolunteerTripService : ICrudService<VolunteerTrip, VolunteerTripInsertRequest,VolunteerTripUpdateRequest, GetTripApplicationsResponse>
    {
        /// <summary>
        /// getting trip applications for choosen event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetTripApplicationsResponse>> GetTripApplications(int id);
        /// <summary>
        /// getting trip status for 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<GetTripsDetailsForEventResponse> GetTripStatusForEvent(int id);
    }
}
