using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface INotificationService
    {
        /// <summary>
        /// adding meeting details
        /// </summary>
        /// <param name="addMeetingRequest"></param>
        /// <returns></returns>
        Task AddNotificationAsync(UpSertMeetingRequest addNotificationRequest);
        /// <summary>
        /// update meeting details
        /// </summary>
        /// <param name="updateMeetingRequest"></param>
        /// <returns></returns>
        Task UpdateNotificationAsync(int id,UpSertMeetingRequest updateNotificationRequest);
        /// <summary>
        /// deleting meeting
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteNotificationAsync(int id);
        /// <summary>
        /// get meeting for choosen day
        /// </summary>
        /// <returns></returns>
        Task<List<GetMeetingsResponse>> NotificationListAsync(int id);
    }
}
