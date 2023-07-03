using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Material;
using StraniVari.WinUI.Service;
using StraniVari.WinUI.Volunteers;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmSchoolTabs : Form
    {
        ApiService _apiServiceVolunteerDetails = new ApiService("SchoolVolunteers/get");
        ApiService _apiServiceSchoolVolunteers = new ApiService("SchoolVolunteers");
        ApiService _apiServiceSchoolMaterial = new ApiService("SchoolMaterials");
        ApiService _apiServiceSchoolMaterialGet = new ApiService("SchoolMaterials/get");
        private GetSchoolsForEventResponse selectedSchool;

        public frmSchoolTabs(GetSchoolsForEventResponse selectedSchool)
        {
            InitializeComponent();
            this.selectedSchool = selectedSchool;
        }

        private void frmSchoolTabs_Load(object sender, EventArgs e)
        {
            frmVolunteerDetails_Load(sender, e);
            frmMaterialDetails_Load(sender, e);
        }

        public async void frmVolunteerDetails_Load(object sender, EventArgs e)
        {
            dgvVolunteers.AutoGenerateColumns = false;
            var result = await _apiServiceVolunteerDetails.GetById<List<GetVolunteersForSchoolResponse>>(selectedSchool.SchoolEventId);
            dgvVolunteers.DataSource = result;
        }

        public async void frmMaterialDetails_Load(object sender, EventArgs e)
        {
            dgvMaterialForSchool.AutoGenerateColumns = false;
            var result = await _apiServiceSchoolMaterialGet.GetById<List<GetMaterialsForSchoolRequest>>(selectedSchool.SchoolEventId);
            dgvMaterialForSchool.DataSource = result;
        }

        private async void dgvVolunteers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedVolunteer = dgvVolunteers.SelectedRows[0].DataBoundItem as GetVolunteersForSchoolResponse;

            if (selectedVolunteer != null)
            {
                if (e.ColumnIndex == 6)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmVolunteerDetails_Load(sender, e);
                    }
                    else
                    {
                        await _apiServiceSchoolVolunteers.Delete<ResponseResult>(selectedVolunteer.SchoolVolunteerId);
                        frmVolunteerDetails_Load(sender, e);
                    }
                }
            }
        }

        private void dgvVolunteers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var selectedVolunteer = dgvVolunteers.SelectedRows[0].DataBoundItem as GetVolunteersForSchoolResponse;

            if (selectedVolunteer != null)
            {
                frmEditVolunteerDetails frmEditVolunteerDetails = new frmEditVolunteerDetails(selectedVolunteer);
                frmEditVolunteerDetails.ShowDialog();
            }
        }

        private async void dgvMaterialForSchool_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedMaterial = dgvMaterialForSchool.SelectedRows[0].DataBoundItem as GetMaterialsForSchoolRequest;
            if (selectedMaterial != null)
            {
                if (e.ColumnIndex == 3)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmMaterialDetails_Load(sender, e);
                    }
                    else
                    {
                        await _apiServiceSchoolMaterial.Delete<ResponseResult>(selectedMaterial.SchoolMaterialId);
                        frmMaterialDetails_Load(sender, e);
                    }
                }
            }
        }

        private void dgvMaterialForSchool_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedMaterial = dgvMaterialForSchool.SelectedRows[0].DataBoundItem as GetMaterialsForSchoolRequest;
            if (selectedMaterial != null)
            {
                frmEditMaterialDetails frmEditMaterialDetails = new frmEditMaterialDetails(selectedMaterial);
                frmEditMaterialDetails.ShowDialog();
            }
        }
    }
}
