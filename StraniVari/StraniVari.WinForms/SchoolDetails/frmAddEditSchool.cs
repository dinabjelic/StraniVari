using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmAddEditSchool : Form
    {
        ApiService _apiService = new ApiService("Schools");
        public GetSchoolDetailsResponse SelectedSchool { get; }
        public frmAddEditSchool(GetSchoolDetailsResponse selectedSchool=null)
        {
            InitializeComponent();
            SelectedSchool = selectedSchool;
        }


        private void frmAddEditSchool_Load(object sender, EventArgs e)
        {
            if(SelectedSchool != null)
            {
                txtSchoolName.Text = SelectedSchool.Name;
                txtSchoolCity.Text = SelectedSchool.City;
                txtSchoolAddress.Text = SelectedSchool.Address;
            }
        }

        private async void btnEditSchoolDetails_Click(object sender, EventArgs e)
        {
            var school = new SchoolUpsertRequest
            {
                Name = txtSchoolName.Text,
                Address = txtSchoolAddress.Text,
                City = txtSchoolCity.Text
            };

            if(SelectedSchool == null)
            {
                await _apiService.Insert<ResponseResult>(school);
                MessageBox.Show("School successfully added.", "Infomation", MessageBoxButtons.OK);
            }
            else
            {
                await _apiService.Update<ResponseResult>(school, SelectedSchool.Id);
                MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
            }
            this.DialogResult = DialogResult.OK;
            Close();

            var principalForm = Application.OpenForms.OfType<frmAllSchools>().FirstOrDefault();
            principalForm.frmAllSchools_Load(sender, e);
        }
    }
}
