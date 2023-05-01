using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IMaterialSchoolService : I_CrudService<SchoolMaterial, InsertMaterialToSchoolRequest, UpdateMaterialToSchoolRequest, GetMaterialsForSchoolRequest>
    {
        /// <summary>
        /// add material to school
        /// </summary>
        /// <param name="insertMaterialToSchoolRequest"></param>
        /// <returns></returns>
        Task Insert(InsertMaterialToSchoolRequest insertMaterialToSchoolRequest);

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
        Task<List<GetMaterialsForSchoolRequest>> GetById(int id);
        ///// <summary>
        ///// update material choosen for school
        ///// </summary>
        ///// <param name="updateMaterialToSchoolRequest"></param>
        ///// <returns></returns>
        //Task UpdateMaterialForSchoolAsync(UpdateMaterialToSchoolRequest updateMaterialToSchoolRequest);
        ///// <summary>
        ///// delete material
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //Task DeleteMaterialForSchoolAsync(int id);


    }
}
