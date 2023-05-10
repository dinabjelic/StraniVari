using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IPlanAndProgrammeService: ICrudService<PlanAndProgramme, UpSertPlanAndProgrammeRequest, UpSertPlanAndProgrammeRequest, GetPlanAndProgrameResposnse>
    {
    }
}
