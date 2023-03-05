using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class NotificationsController : BaseApiController
    {
        private readonly INotificationService _meetingService;

        public NotificationsController(INotificationService meetingService)
        {
            _meetingService = meetingService;
        }
       
        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> AddNotification(UpSertMeetingRequest addNotificationRequest)
        {
            await _meetingService.AddNotificationAsync(addNotificationRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpPut]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> UpdateNotification(int id, UpSertMeetingRequest updateNotificationRequest)
        {
            await _meetingService.UpdateNotificationAsync(id, updateNotificationRequest);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpDelete]
        [Authorize(Roles = Role.Administrator)]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            await _meetingService.DeleteNotificationAsync(id);
            return Ok(new ResponseResult { Message = "You succeeded" });
        }

        [HttpGet]
        [Authorize(Roles = Role.Administrator + "," + Role.RegularUser)]
        public async Task<IActionResult> NotificationList(int id)
        {
            return Ok(await _meetingService.NotificationListAsync(id));
        }
    }
}
