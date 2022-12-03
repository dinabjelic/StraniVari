using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IMaterialSchoolService
    {
        /// <summary>
        /// add material to school
        /// </summary>
        /// <param name="insertMaterialToSchoolRequest"></param>
        /// <returns></returns>
        Task AddMaterialToSchoolAsync(InsertMaterialToSchoolRequest insertMaterialToSchoolRequest);
        /// <summary>
        /// getting list of material for choosen school
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetMaterialsForSchoolRequest>> MaterialForSchoolAsync(int id);
        /// <summary>
        /// update material choosen for school
        /// </summary>
        /// <param name="updateMaterialToSchoolRequest"></param>
        /// <returns></returns>
        Task UpdateMaterialForSchoolAsync(UpdateMaterialToSchoolRequest updateMaterialToSchoolRequest);
        /// <summary>
        /// delete material
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteMaterialForSchoolAsync(int id);
    }
}
