using StraniVari.Common.Constants;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Volunteers
{
    public partial class frmAddEditVolunteer : Form
    {
        ApiService _apiService = new ApiService("Volunteers");
        public GetVolunteerDetailsResposne SelectedVolunteer { get; }
        public frmAddEditVolunteer(GetVolunteerDetailsResposne selectedVolunteers=null)
        {
            InitializeComponent();
            SelectedVolunteer = selectedVolunteers;
        }

        private void frmAddEditVolunteer_Load(object sender, EventArgs e)
        {
            if (SelectedVolunteer != null)
            {
                txtFirstName.Text = SelectedVolunteer.FirstName;
                txtLastName.Text = SelectedVolunteer.LastName;
                txtVolunteerCity.Text = SelectedVolunteer.City;
                txtVolunteerAddress.Text = SelectedVolunteer.Address;
                dtpBirth.Value = SelectedVolunteer.DateOfBirth;
                txtUsername.Text = SelectedVolunteer.Username;
            }
        }

        private async void btnEditVolunteerDetails_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                var volunteer = new VolunteerUpSertRequest
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Address = txtVolunteerAddress.Text,
                    City = txtVolunteerCity.Text,
                    DateOfBirth = dtpBirth.Value, 
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                if (SelectedVolunteer == null)
                {
                    await _apiService.Insert<ResponseResult>(volunteer);
                    MessageBox.Show("Volunteer successfully added.", "Infomation", MessageBoxButtons.OK);
                }
                else
                {
                    await _apiService.Update<ResponseResult>(volunteer, SelectedVolunteer.Id);
                    MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }

            var principalForm = Application.OpenForms.OfType<frmAllVolunteers>().FirstOrDefault();
            principalForm.frmAllVolunteers_Load(sender, e);

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
            if((!string.IsNullOrWhiteSpace(txtPassword.Text) || !string.IsNullOrWhiteSpace(txtConfirmPassword.Text)) && txtPassword.Text != txtConfirmPassword.Text)
            {
                err.SetError(txtConfirmPassword, Constants.ConfirmPassword);
                return false;
            }
            return true;
        }
    }
}
