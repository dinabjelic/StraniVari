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
            }
        }

        private async void btnEditVolunteerDetails_Click(object sender, EventArgs e)
        {
            var volunteer = new VolunteerUpSertRequest
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtVolunteerAddress.Text,
                City = txtVolunteerCity.Text,
                DateOfBirth = dtpBirth.Value
            };

            if(SelectedVolunteer == null)
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

            var principalForm = Application.OpenForms.OfType<frmAllVolunteers>().FirstOrDefault();
            principalForm.frmAllVolunteers_Load(sender, e);

        }
    }
}
