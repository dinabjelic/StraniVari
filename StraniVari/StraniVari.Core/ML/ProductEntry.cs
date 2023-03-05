using Microsoft.ML.Data;

namespace StraniVari.Core.ML
{
    public class Copurchase_prediction
    {
        public float Score { get; set; }
    }
    public class ProductEntry
    {
        [KeyType(count: 2000)]
        public uint MaterialID { get; set; }
        [KeyType(count: 2000)]
        public uint CoPurchaseProductID { get; set; }
        public float Label { get; set; }
    }

    public class CountMaterial
    {
        public int EventSchoolId { get; set; }
        public int MaterialCount { get; set; }
    }

    public class EventSchoolMaterial
    {
        public int EventSchoolId { get; set; }
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
    }
}
