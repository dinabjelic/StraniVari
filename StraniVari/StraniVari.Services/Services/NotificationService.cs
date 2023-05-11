using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Database;
using StraniVari.Services.Base;
using StraniVari.Services.Interfaces;

namespace StraniVari.Services.Services
{
    public class NotificationService : BaseCrudService<Notification, UpSertMeetingRequest, UpSertMeetingRequest,GetMeetingsResponse>, INotificationService
    {
        private readonly StraniVariDbContext _straniVariDbContext;
        public NotificationService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }
        public async Task<List<GetMeetingsResponse>> NotificationListAsync(int id)
        {
            var notificationList = await _straniVariDbContext.Notifications
                .Where(x => x.EventId == id)
                .Select(x => new GetMeetingsResponse
                {
                    Id = x.Id,
                    Address = x.Address,
                    City = x.City,
                    MeetingDate = x.MeetingDate,
                    DayOfWeek = x.DayOfWeek,
                    MeetingPlace = x.MeetingPlace,
                    MeetingTheme = x.MeetingTheme,
                }).ToListAsync();

            return notificationList;
        }
    }
}
