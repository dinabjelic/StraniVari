using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IVolunteerService: ICrudService<Volunteer, VolunteerUpSertRequest, VolunteerUpSertRequest, GetVolunteerDetailsResposne>
    {
        /// <summary>
        /// getting volunteer details
        /// </summary>
        /// <returns></returns>
        Task<List<GetVolunteerDetailsResposne>> GetAll();
        /// <summary>
        /// getting volunteer details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<GetVolunteerDetailsResposne> GetById(int id);
        /// <summary>
        /// adding volunteer
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Task Insert(VolunteerUpSertRequest addVolunteerRequest);
        /// <summary>
        /// updating volunteer details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateVolunteerRequest"></param>
        /// <returns></returns>
        Task Update(int id, VolunteerUpSertRequest updateVolunteerRequest);
        ///// <summary>
        ///// deleting volunteer
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        Task Delete(int id);

    }
}
