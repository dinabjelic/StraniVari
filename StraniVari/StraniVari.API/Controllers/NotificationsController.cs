using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class NotificationsController : BaseCRUDController<Notification, UpSertMeetingRequest, UpSertMeetingRequest,GetMeetingsResponse>
    {
        public NotificationsController(INotificationService meetingService):base(meetingService)
        {
        }
    }
}
