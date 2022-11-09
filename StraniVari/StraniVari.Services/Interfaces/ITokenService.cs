using StraniVari.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraniVari.Services.Interfaces
{
    public interface ITokenService
    {
        /// <summary>
        /// Method that creates token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string CreateToken(User user);
    }
}
