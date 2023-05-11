using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;
using StraniVari.Services.Services;

namespace StraniVari.API.Controllers
{
    public class NotificationsController : BaseCRUDController<Notification, UpSertMeetingRequest, UpSertMeetingRequest,GetMeetingsResponse>
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService):base(notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet("notifications")]
        public async Task<IActionResult> NotificationList(int id)
        {
            return Ok(await _notificationService.NotificationListAsync(id));
        }
    }
}
