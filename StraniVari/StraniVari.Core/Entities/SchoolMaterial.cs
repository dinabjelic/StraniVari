namespace StraniVari.Core.Entities
{
    public class SchoolMaterial:BaseEntity
    {
        public EventSchool EventSchool { get; set; }
        public int EventSchoolId { get; set; }

        public Material Material { get; set; }
        public int MaterialId { get; set; }

        public int Quantity { get; set; }
    }
}
