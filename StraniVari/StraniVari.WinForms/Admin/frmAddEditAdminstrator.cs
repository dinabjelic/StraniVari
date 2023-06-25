using StraniVari.Common.Constants;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Admin
{
    public partial class frmAddEditAdminstrator : Form
    {
        ApiService _apiService = new ApiService("Administrator");
        private GetAdministratorDetailsResponse selectedAdmin;
        public frmAddEditAdminstrator(GetAdministratorDetailsResponse selectedAdmin=null)
        {
            InitializeComponent();
            this.selectedAdmin = selectedAdmin;
        }

        private void frmAddEditAdminstrator_Load(object sender, EventArgs e)
        {
            if (selectedAdmin != null)
            {
                txtFirstName.Text = selectedAdmin.FirstName;
                txtLastName.Text = selectedAdmin.LastName;
                txtVolunteerCity.Text = selectedAdmin.City;
                txtVolunteerAddress.Text = selectedAdmin.Address;
                dtpBirth.Value = selectedAdmin.DateOfBirth;
                txtUsername.Text = selectedAdmin.Username;
            }
        }

        private async void btnEditAdministratorDetails_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                var administrator = new AdministratorUpSertRequest
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Address = txtVolunteerAddress.Text,
                    City = txtVolunteerCity.Text,
                    DateOfBirth = dtpBirth.Value,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                if (selectedAdmin == null)
                {
                    await _apiService.Insert<ResponseResult>(administrator);
                    MessageBox.Show("Administrator successfully added.", "Infomation", MessageBoxButtons.OK);
                }
                else
                {
                    await _apiService.Update<ResponseResult>(administrator, selectedAdmin.Id);
                    MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }

            var principalForm = Application.OpenForms.OfType<frmUsersTab>().FirstOrDefault();
            principalForm.frmAllAdmins_Load(sender, e);
        }

        private bool ValidateEntry()
        {
            return ValidateControl(txtFirstName, Constants.RequiredValue) &&
                   ValidateControl(txtLastName, Constants.RequiredValue) &&
                   ValidateControl(txtVolunteerCity, Constants.RequiredValue) &&
                   ValidateControl(txtVolunteerAddress, Constants.RequiredValue) &&
                   ValidateControl(dtpBirth, Constants.RequiredValue) &&
                   ValidateControl(txtUsername, Constants.RequiredValue) &&
                   ValidateConfirmPassword();
        }

        private bool ValidateControl(Control control, string message)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                err.SetError(control, message);
                return false;
            }
            err.Clear();
            return true;
        }

        private bool ValidateConfirmPassword()
        {
            if ((!string.IsNullOrWhiteSpace(txtPassword.Text) || !string.IsNullOrWhiteSpace(txtConfirmPassword.Text)) && txtPassword.Text != txtConfirmPassword.Text)
            {
                err.SetError(txtConfirmPassword, Constants.ConfirmPassword);
                return false;
            }
            return true;
        }
    }
}
