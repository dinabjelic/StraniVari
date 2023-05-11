using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IMaterialSchoolService : ICrudService<SchoolMaterial, InsertMaterialToSchoolRequest, UpdateMaterialToSchoolRequest, GetMaterialsForSchoolRequest>
    {
        /// <summary>
        /// recomending materials for school
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<SchoolMaterial> Recommend(int eventSchoolId);

        /// <summary>
        /// getting list of material for choosen school
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetMaterialsForSchoolRequest>> GetMaterialsForSchool(int id);
    }
}
