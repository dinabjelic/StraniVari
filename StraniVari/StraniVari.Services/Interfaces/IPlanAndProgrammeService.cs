using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Base;

namespace StraniVari.Services.Interfaces
{
    public interface IPlanAndProgrammeService: ICrudService<PlanAndProgramme, UpSertPlanAndProgrammeRequest, GetPlanAndProgrameResposnse>
    {
        ///// <summary>
        ///// adding new plan and programme
        ///// </summary>
        ///// <param name="addPlanAndProgrammeRequest"></param>
        ///// <returns></returns>
        //Task AddPlanAndProgrammeAsync(UpSertPlanAndProgrammeRequest addPlanAndProgrammeRequest);
        ///// <summary>
        ///// update plan and programme details
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="updatePlanAndProgrammeRequest"></param>
        ///// <returns></returns>
        //Task UpdatePlanAndProgrammeAsync(int id, UpSertPlanAndProgrammeRequest updatePlanAndProgrammeRequest);
        /// <summary>
        /// get plan and program for choosen day
        /// </summary>
        /// <param name="dayOfWeek"></param>
        /// <returns></returns>
        Task<List<GetPlanAndProgrameResposnse>> PlanAndProgrammeListAsync(DayOfWeek? dayOfWeek, int id);
    }
}
