using StraniVari.Core.Responses;

namespace StraniVari.Core.Requests
{
    public class SchoolVolunteerMaterialRequest
    {
        public int SchoolId { get; set; }
        public int EventId { get; set; }
        public int NumberOfChildren { get; set; }
        public IEnumerable<GetMaterialResponse> Material { get; set; }     
        public IEnumerable<GetVolunteersForEventResponse> Volunteers { get; set; }
    }
}
