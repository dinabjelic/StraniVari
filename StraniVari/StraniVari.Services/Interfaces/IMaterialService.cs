using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IMaterialService : ICrudService<Material, MaterialUpsertRequest, MaterialUpsertRequest,GetMaterialDetailsResponse>
    {
        /// <summary>
        /// returns filtered material
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        Task<List<Material>> GetFilteredMaterials(string searchTerm);
    }
}
