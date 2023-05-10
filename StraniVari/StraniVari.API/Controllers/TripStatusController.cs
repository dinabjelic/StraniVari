using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.Services.Interfaces;

namespace StraniVari.API.Controllers
{
    public class TripStatusController : BaseCRUDController<TripStatus, StatusUpSertRequest, StatusUpSertRequest, GetStatusResponse>
    {
        public TripStatusController(ITripStatusService tripStatus) : base(tripStatus)
        {
        }
    }
}
