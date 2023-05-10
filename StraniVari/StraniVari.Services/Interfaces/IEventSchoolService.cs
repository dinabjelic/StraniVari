using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Services;

namespace StraniVari.Services.Interfaces
{
    public interface IEventSchoolService: ICrudService<EventSchool, EventSchoolInsertRequest, EventSchoolUpdateRequest, GetSchoolsForEventResponse>
    {
        /// <summary>
        /// adding schools to choosen event
        /// </summary>
        /// <param name="addEventSchoolUpSertRequest"></param>
        /// <returns></returns>
        Task Insert(EventSchoolInsertRequest addEventSchoolInsertRequest);
        /// <summary>
        /// getting 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetSchoolsForEventResponse>> GetById(int id);
    }
}
