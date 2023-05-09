using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IVolunteerTripService
    {
        /// <summary>
        /// getting trip applications for choosen event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetTripApplicationsResponse>> GetTripApplications(int id);
        /// <summary>
        /// updating trip status for choosen volunteer
        /// </summary>
        /// <param name="id"></param>
        /// <param name="req"></param>
        /// <returns></returns>
        Task UpdateVolunteerDetailsAsync(int id, VolunteerTripUpsertRequest req);
        /// <summary>
        /// inserting trip status for logged in volonteer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Insert(int id);
        /// <summary>
        /// getting trip status for 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<GetTripsDetailsForEvent> GetTripStatusForLoggedInUser(int id);
    }
}
