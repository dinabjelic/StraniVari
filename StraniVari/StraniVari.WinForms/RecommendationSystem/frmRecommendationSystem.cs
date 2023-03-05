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
            //bool duplicate = false;
            var result = await _apiService.Get<List<GetMaterialDetailsResponse>>();
            //var duplicateList = new List<int>();
            //foreach (var x in MaterialForSchool)
            //{
            //    foreach (var y in MaterialList)
            //    {
            //        if (x.MaterialId == y.MaterialId)
            //        {
            //            //duplicate = true;
            //            duplicateList.Add(y.MaterialId);
            //            //break;
            //        }
            //    }
            //}
            //if(duplicateList.Count > 1)
            //{
            //    duplicateList = null;
            //}

            //if (duplicateList != null)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("There are no recommended materials for this school");
            //    this.Close();
            //}

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
