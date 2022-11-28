using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IMaterialSchoolService
    {
        /// <summary>
        /// getting list of materials
        /// </summary>
        /// <returns></returns>
        Task<List<GetMaterialSchoolDetailsResponse>> MaterialSchoolListAsync();
        /// <summary>
        /// adding material to school
        /// </summary>
        /// <param name="addMaterialToSchoolRequest"></param>
        /// <returns></returns>
        Task AddMaterialToSchoolAsync(MaterialSchoolUpSertRequest addMaterialToSchoolRequest);
        /// <summary>
        /// removing material from school
        /// </summary>
        /// <param name="materialSchoolDeleteRequest"></param>
        /// <returns></returns>
        Task RemoveMaterialFromSchoolAsync(MaterialSchoolDeleteRequest materialSchoolDeleteRequest);
    }
}
