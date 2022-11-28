using StraniVari.Core.Dtos;

namespace StraniVari.Core.Requests
{
    public class VolunteerSchoolUpSertRequest
    {
        public List<VolunteerDto> Volunters { get; set; } = new List<VolunteerDto>();

        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolCity { get; set; }
    }
}
