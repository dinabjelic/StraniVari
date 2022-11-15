using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface ISchoolService
    {
        /// <summary>
        /// Returns all schools which are available 
        /// </summary>
        /// <returns></returns>
        Task<List<GetSchoolDetailsResponse>> SchoolListAsync();
        /// <summary>
        /// Returns school details for choosen school
        /// </summary>
        /// <param name = "id" ></ param >
        /// < returns ></ returns >
        Task<GetSchoolDetailsResponse> GetSchoolDetailsAsync(int id);
        /// <summary>
        /// Method that saves school in database
        /// </summary>
        /// <param name="addSchoolRequest"></param>
        /// <returns></returns>
        Task AddSchoolAsync(SchoolUpsertRequest addSchoolRequest);
        /// <summary>
        /// Editing existing school
        /// </summary>
        /// <param name="updateSchoolRequest"></param>
        /// <returns></returns>
        Task UpdateSchoolAsync(int id, SchoolUpsertRequest updateSchoolRequest);
        /// <summary>
        /// Deletes choosen school
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteSchoolAsync(int id);
    }
}
