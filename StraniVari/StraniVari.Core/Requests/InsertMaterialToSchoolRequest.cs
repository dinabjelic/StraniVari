namespace StraniVari.Core.Requests
{
    public class InsertMaterialToSchoolRequest
    {
        public int EventSchoolId { get; set; }
        public int[] Materials { get; set; }
    }
}
