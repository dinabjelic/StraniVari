using StraniVari.Core.Entities;

namespace StraniVari.Services.Interfaces
{
    public interface ITokenService
    {
        /// <summary>
        /// Method that creates token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string CreateToken(User user, IList<string> userRoles);
    }
}
