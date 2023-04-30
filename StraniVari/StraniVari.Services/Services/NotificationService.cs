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
    public class NotificationService : BaseCrudService<Notification, UpSertMeetingRequest, GetMeetingsResponse>, INotificationService
    {
        private readonly StraniVariDbContext _straniVariDbContext;

        public NotificationService(StraniVariDbContext straniVariDbContext, IMapper mapper) : base(straniVariDbContext, mapper)
        {
            _straniVariDbContext = straniVariDbContext;
        }

        public async Task AddNotificationAsync(UpSertMeetingRequest addNotificationRequest)
        {
            var newNotification = new Notification
            {
                Address = addNotificationRequest.Address,
                City = addNotificationRequest.City,
                MeetingPlace= addNotificationRequest.MeetingPlace,
                MeetingDate = addNotificationRequest.MeetingDate,
                DayOfWeek = addNotificationRequest.DayOfWeek, 
                MeetingTheme= addNotificationRequest.MeetingTheme, 
                EventId = addNotificationRequest.EventId
            };

            await _straniVariDbContext.Notifications.AddAsync(newNotification);
            await _straniVariDbContext.SaveChangesAsync();
        }

        public async Task DeleteNotificationAsync(int id)
        {
            var notificationFound = await _straniVariDbContext.Notifications.FirstOrDefaultAsync(x => x.Id == id);

            if (notificationFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            _straniVariDbContext.Notifications.Remove(notificationFound);
            await _straniVariDbContext.SaveChangesAsync();
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

        public async Task UpdateNotificationAsync(int id,UpSertMeetingRequest updateNotificationRequest)
        {
            if (updateNotificationRequest == null)
            {
                throw new ArgumentException("Invalid request");
            }

            var meetingFound = await _straniVariDbContext.Notifications.FirstOrDefaultAsync(x => x.Id == id);

            if (meetingFound == null)
            {
                throw new ArgumentException("Invalid id");
            }

            meetingFound.Address = updateNotificationRequest.Address;
            meetingFound.City = updateNotificationRequest.City;
            meetingFound.MeetingPlace = updateNotificationRequest.MeetingPlace;
            meetingFound.MeetingDate = updateNotificationRequest.MeetingDate;
            meetingFound.DayOfWeek = updateNotificationRequest.DayOfWeek;
            meetingFound.MeetingTheme = updateNotificationRequest.MeetingTheme;

            _straniVariDbContext.Notifications.Update(meetingFound);
            await _straniVariDbContext.SaveChangesAsync();
        }
    }
}
