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
        Task<List<GetTripApplicationsResponse>> GetById(int id);
        /// <summary>
        /// updating trip status for choosen volunteer
        /// </summary>
        /// <param name="id"></param>
        /// <param name="req"></param>
        /// <returns></returns>
        Task Update(int id, VolunteerTripUpdateRequest req);
        /// <summary>
        /// inserting trip status for logged in volonteer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Insert(VolunteerTripInsertRequest req);
        /// <summary>
        /// getting trip status for 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<GetTripsDetailsForEventResponse> GetTripStatusForEvent(int id);
    }
}
