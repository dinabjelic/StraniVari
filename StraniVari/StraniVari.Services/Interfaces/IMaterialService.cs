using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IMaterialService
    {
        /// <summary>
        /// getting list of materials for schools
        /// </summary>
        /// <returns></returns>
        Task<List<GetMaterialDetailsResponse>> GetMaterialsAsync();
        /// <summary>
        /// adding new material
        /// </summary>
        /// <param name="addMaterialRequest"></param>
        /// <returns></returns>
        Task AddMaterialAsync(MaterialUpsertRequest addMaterialRequest);
        /// <summary>
        /// updating exisiting material
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateMaterialRequest"></param>
        /// <returns></returns>
        Task UpdatedMaterialAsync(int id, MaterialUpsertRequest updateMaterialRequest);
        /// <summary>
        /// deleting existing material
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteMaterialAsync(int id);
        
    }
}
