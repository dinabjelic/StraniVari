using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface IMeetingService
    {
        /// <summary>
        /// adding meeting details
        /// </summary>
        /// <param name="addMeetingRequest"></param>
        /// <returns></returns>
        Task AddMeetingAsync(UpSertMeetingRequest addMeetingRequest);
        /// <summary>
        /// update meeting details
        /// </summary>
        /// <param name="updateMeetingRequest"></param>
        /// <returns></returns>
        Task UpdateMeetingAsync(int id,UpSertMeetingRequest updateMeetingRequest);
        /// <summary>
        /// deleting meeting
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteMettingAsync(int id);
        /// <summary>
        /// get meeting for choosen day
        /// </summary>
        /// <returns></returns>
        Task<List<GetMeetingsResponse>> MeetingListAsync(DayOfWeek meetingDay);
    }
}
