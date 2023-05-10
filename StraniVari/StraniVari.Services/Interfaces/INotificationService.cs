using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface INotificationService : ICrudService<Notification, UpSertMeetingRequest, UpSertMeetingRequest, GetMeetingsResponse>
    {
    }
}
