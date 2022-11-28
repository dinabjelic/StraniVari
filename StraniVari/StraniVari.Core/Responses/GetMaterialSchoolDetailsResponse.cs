using StraniVari.Core.Entities;

namespace StraniVari.Core.Responses
{
    public class GetMaterialSchoolDetailsResponse
    {
        public string SchoolName { get; set; }
        public string SchoolAdress { get; set; }
        public string SchoolCity { get; set; }
        public string MaterialName { get; set; }
        public int VolunteeringYear { get; set; }
    }
}
