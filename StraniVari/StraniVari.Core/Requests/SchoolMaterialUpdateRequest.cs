namespace StraniVari.Core.Requests
{
    public class SchoolMaterialUpdateRequest
    {
        public bool IsChecked { get; set; }
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public int Quantity { get; set; }
    }
}
