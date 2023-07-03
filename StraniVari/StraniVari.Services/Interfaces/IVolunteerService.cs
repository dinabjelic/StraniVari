﻿using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IVolunteerService: ICrudService<Volunteer, VolunteerUpSertRequest, VolunteerUpSertRequest, GetVolunteerDetailsResposne>
    {
        /// <summary>
        /// returns filtered users
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        Task<List<Volunteer>> GetFilteredUsers(string searchTerm);
    }
}

