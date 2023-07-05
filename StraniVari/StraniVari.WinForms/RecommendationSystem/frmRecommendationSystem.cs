using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.RecommendationSystem
{
    public partial class frmRecommendationSystem : Form
    {
        ApiService _apiService = new ApiService("Materials");
        public List<SchoolMaterial>? MaterialList { get; }
        public GetSchoolsForEventResponse SelectedElement { get; }
        public List<GetMaterialsForSchoolRequest> MaterialForSchool { get; }

        public frmRecommendationSystem(List<SchoolMaterial>? materialList, GetSchoolsForEventResponse selectedElement, List<GetMaterialsForSchoolRequest> materialForSchool)
        {
            InitializeComponent();
            MaterialList = materialList;
            SelectedElement = selectedElement;
            MaterialForSchool = materialForSchool;
        }

        private async void frmRecommendationSystem_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<GetMaterialDetailsResponse>>();

            foreach (var x in result)
            {
                for (int i = 0; i < MaterialList.Count; i++)
                {
                    if (x.Id == MaterialList[i].MaterialId)
                    {
                        rtbRecommend.Text += string.Format("{0}\r\n", x.Name);
                    }
                }
            }
        }
    }
}
