using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Material
{
    public partial class frmMaterialDetails : Form
    {
        private readonly ApiService _apiService = new ApiService("SchoolMaterials");
        public EventUpsertRequest SelectedEvent { get; }
        public GetSchoolsForEventResponse SelectedElement { get; }

        public frmMaterialDetails(EventUpsertRequest selectedEvent = null, GetSchoolsForEventResponse selectedElement = null)
        {
            InitializeComponent();
            SelectedEvent = selectedEvent;
            SelectedElement = selectedElement;
        }
        public async void frmMaterialDetails_Load(object sender, EventArgs e)
        {
            dgvMaterialForSchool.AutoGenerateColumns = false;
            var result = await _apiService.GetById<List<GetMaterialsForSchoolRequest>>(SelectedElement.SchoolEventId);
            dgvMaterialForSchool.DataSource = result;
            await LoadEventDetails();
        }
        private async Task LoadEventDetails()
        {
            txtName.Text = SelectedEvent.Name;
            txtTheme.Text = SelectedEvent.StraniVariTheme;
            txtStartDate.Text = SelectedEvent.StartDate.ToString("D");
            txtEndDate.Text = SelectedEvent.EndDate.ToString("D");
            txtSchool.Text = SelectedElement.SchoolName;
        }

        private async void dgvMaterialForSchool_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedMaterial = dgvMaterialForSchool.SelectedRows[0].DataBoundItem as GetMaterialsForSchoolRequest;
            Text = e.ColumnIndex.ToString();
            if (selectedMaterial != null)
            {
                if (e.ColumnIndex == 3)
                {
                    frmEditMaterialDetails frmEditMaterialDetails = new frmEditMaterialDetails(selectedMaterial, SelectedEvent, SelectedElement);
                    frmEditMaterialDetails.Show();
                }
                else if (e.ColumnIndex == 4)
                {
                    MessageBox.Show("You are about to delete this item!");
                    await _apiService.Delete<ResponseResult>(selectedMaterial.SchoolMaterialId);
                    frmMaterialDetails_Load(sender, e);
                }
            }
           
        }
    }
}
