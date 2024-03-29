﻿using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface ISchoolService : ICrudService<School, SchoolUpsertRequest, SchoolUpsertRequest, GetSchoolDetailsResponse>
    {
        /// <summary>
        /// returns filtered schools
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        Task<List<GetSchoolDetailsResponse>> GetFilteredSchools(string searchTerm);
    }
}
