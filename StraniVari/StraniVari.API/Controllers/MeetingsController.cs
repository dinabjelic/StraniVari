using Microsoft.AspNetCore.Mvc;
using StraniVari.Core.Requests;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class MeetingsController : BaseApiController
    {
        private readonly IMeetingService _meetingService;

        public MeetingsController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }
       
        [HttpPost]
        public async Task<IActionResult> AddMeeting(UpSertMeetingRequest addMeetingRequest)
        {
            await _meetingService.AddMeetingAsync(addMeetingRequest);
            return Ok("You succeeded");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMeeting(int id, UpSertMeetingRequest updateMeetingRequest)
        {
            await _meetingService.UpdateMeetingAsync(id, updateMeetingRequest);
            return Ok("You succeeded");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMeeting(int id)
        {
            await _meetingService.DeleteMettingAsync(id);
            return Ok("You succeeded");
        }

        [HttpGet]
        public async Task<IActionResult> MeetingList(DayOfWeek? meetingDay, int? volunteeringYear)
        {
            return Ok(await _meetingService.MeetingListAsync(meetingDay, volunteeringYear));
        }
    }
}
