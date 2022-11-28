using StraniVari.Core.Dtos;

namespace StraniVari.Core.Requests
{
    public class MaterialSchoolUpSertRequest
    {
        public List<MaterialDto> Materials { get; set; }
        public int SchoolId { get; set; }
        public int Quantity { get; set; }
        public int VolunteeringYear { get; set; }
    }
}
