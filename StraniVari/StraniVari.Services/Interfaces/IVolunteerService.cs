using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IVolunteerService
    {
        /// <summary>
        /// getting volunteer details
        /// </summary>
        /// <returns></returns>
        Task<List<GetVolunteerDetailsResposne>> VolunteerListAsync();
        /// <summary>
        /// getting volunteer details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<GetVolunteerDetailsResposne> GetVolunteerDetailsAsync(int id);
        /// <summary>
        /// adding volunteer
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Task AddVolunteerAsync(VolunteerUpSertRequest addVolunteerRequest);
        /// <summary>
        /// updating volunteer details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateVolunteerRequest"></param>
        /// <returns></returns>
        Task UpdateVolunteerAsync(int id, VolunteerUpSertRequest updateVolunteerRequest);
        ///// <summary>
        ///// deleting volunteer
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        Task DeleteVolunteerAsync(int id);

    }
}
