using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IVolunteerTripService
    {
        Task<List<GetTripApplicationsResponse>> GetTripApplications(int id);
        Task UpdateVolunteerDetailsAsync(int id, VolunteerTripUpsertRequest rew);
    }
}
