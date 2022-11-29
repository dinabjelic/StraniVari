using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class MeetingService : IMeetingService
    {
        private readonly StraniVariDbContext _straniVariDbContext;

        public MeetingService(StraniVariDbContext straniVariDbContext)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task AddMeetingAsync(UpSertMeetingRequest addMeetingRequest)
        {
            var newMeeting = new Meeting
            {
                Address = addMeetingRequest.Address,
                City = addMeetingRequest.City,
                MeetingPlace= addMeetingRequest.MeetingPlace,
                MeetingDate = addMeetingRequest.MeetingDate,
                VolunteeringYear = addMeetingRequest.VolunteeringYear,
                DayOfWeek = addMeetingRequest.DayOfWeek, 
                MeetingTheme= addMeetingRequest.MeetingTheme
            };

            await _straniVariDbContext.Meetings.AddAsync(newMeeting);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task DeleteMettingAsync(int id)
        {
            var meetingFound = await _straniVariDbContext.Meetings.FirstOrDefaultAsync(x => x.Id == id);

            if (meetingFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.Meetings.Remove(meetingFound);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task<List<GetMeetingsResponse>> MeetingListAsync(DayOfWeek? meetingDay,int? volunteeringYear)
        {
            var meetingList = await _straniVariDbContext.Meetings
                .Where(x => x.DayOfWeek == meetingDay || meetingDay== null 
                || x.VolunteeringYear == volunteeringYear)
                .Select(x => new GetMeetingsResponse
                {
                    Address = x.Address,
                    City = x.City,
                    MeetingDate = x.MeetingDate,
                    DayOfWeek = x.DayOfWeek,
                    MeetingPlace = x.MeetingPlace,
                    MeetingTheme = x.MeetingTheme,
                    VolunteeringYear = x.VolunteeringYear
                }).ToListAsync();

            return meetingList;
        }

        public async Task UpdateMeetingAsync(int id,UpSertMeetingRequest updateMeetingRequest)
        {
            if (updateMeetingRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var meetingFound = await _straniVariDbContext.Meetings.FirstOrDefaultAsync(x => x.Id == id);

            if (meetingFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            meetingFound.Address = updateMeetingRequest.Address;
            meetingFound.City = updateMeetingRequest.City;
            meetingFound.MeetingPlace = updateMeetingRequest.MeetingPlace;
            meetingFound.MeetingDate = updateMeetingRequest.MeetingDate;
            meetingFound.VolunteeringYear = updateMeetingRequest.VolunteeringYear;
            meetingFound.DayOfWeek = updateMeetingRequest.DayOfWeek;
            meetingFound.MeetingTheme = updateMeetingRequest.MeetingTheme;

            _straniVariDbContext.Meetings.Update(meetingFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
