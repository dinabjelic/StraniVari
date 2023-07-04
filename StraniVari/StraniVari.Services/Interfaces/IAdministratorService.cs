using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IAdministratorService: ICrudService<Administrator, AdministratorUpSertRequest, AdministratorUpSertRequest, GetAdministratorDetailsResponse>
    {
        /// <summary>
        /// returns filtered users
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        Task<List<GetAdministratorDetailsResponse>> GetFilteredUsers(string searchTerm);
    }
}
