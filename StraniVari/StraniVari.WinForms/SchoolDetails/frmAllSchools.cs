using Newtonsoft.Json;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Material;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmAllSchools : Form
    {
        private readonly ApiService _apiService = new ApiService("Schools");
        private readonly ApiService _apiServiceDelete = new ApiService("Schools");
        public frmAllSchools()
        {
            InitializeComponent();
        }

        public async void frmAllSchools_Load(object sender, EventArgs e)
        {
            dgvSchools.AutoGenerateColumns = false;
            var result = await _apiService.Get<List<GetSchoolDetailsResponse>>();
            dgvSchools.DataSource = result;
        }

        private async void dgvSchools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedSchool = dgvSchools.SelectedRows[0].DataBoundItem as GetSchoolDetailsResponse;
            if (selectedSchool != null)
            {
                //if (e.ColumnIndex == 4)
                //{
                //    frmAddEditSchool frmAddEditSchool = new frmAddEditSchool(selectedSchool);
                //    frmAddEditSchool.ShowDialog();
                //}
                if (e.ColumnIndex == 4)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmAllSchools_Load(sender, e);
                    }
                    else
                    {
                        await _apiService.Delete<ResponseResult>(selectedSchool.Id);
                        frmAllSchools_Load(sender, e);
                    }
                }
            }
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            frmAddEditSchool frmAddEditSchool = new frmAddEditSchool();
            frmAddEditSchool.ShowDialog();
        }

        private void dgvSchools_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedRecord = dgvSchools.SelectedRows[0].DataBoundItem as GetSchoolDetailsResponse;

            if (selectedRecord != null)
            {
                frmAddEditSchool frmAddEditSchool = new frmAddEditSchool(selectedRecord);
                frmAddEditSchool.ShowDialog();
            }
        }
    }
}
