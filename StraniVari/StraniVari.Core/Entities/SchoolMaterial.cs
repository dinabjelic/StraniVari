namespace StraniVari.Core.Entities
{
    public class SchoolMaterial:BaseEntity
    {
        public int SchoolId { get; set; }
        public School Schools { get; set; }

        public int MaterialId { get; set; }
        public Material Materials { get; set; }

        public int Quantity { get; set; }
        public int VolunteeringYear { get; set; }
    }
}
