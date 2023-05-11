using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.Services.Interfaces
{
    public interface ITripService: ICrudService<Trip, UpSertTripRequest, UpSertTripRequest,GetTripResponse>
    {
        /// <summary>
        /// getting trips details for choosen event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<GetTripsDetailsForEventResponse>> GetById(int id);
    }
}
