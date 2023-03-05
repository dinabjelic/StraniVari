using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Volunteers
{
    public partial class frmEditVolunteerDetails : Form
    {
        ApiService _apiServiceSchoolVolunteers = new ApiService("SchoolVolunteers");
        public GetVolunteersForSchoolResponse SelectedVolunteer { get; }
        public EventUpsertRequest SelectedEvent { get; }
        public GetSchoolsForEventResponse SelectedSchool { get; }
        public frmEditVolunteerDetails(GetVolunteersForSchoolResponse selectedVolunteer, EventUpsertRequest selectedEvent, GetSchoolsForEventResponse selectedSchool)
        {
            InitializeComponent();
            SelectedVolunteer = selectedVolunteer;
            SelectedEvent = selectedEvent;
            SelectedSchool = selectedSchool;
        }

        private void frmEditVolunteerDetails_Load(object sender, EventArgs e)
        {
            txtName.Text = SelectedEvent.Name;
            txtTheme.Text = SelectedEvent.StraniVariTheme;
            txtStartDate.Text = SelectedEvent.StartDate.ToString("D");
            txtEndDate.Text = SelectedEvent.EndDate.ToString("D");
            txtSchool.Text = SelectedSchool.SchoolName;

            txtSFirstName.Text = SelectedVolunteer.FirstName;
            txtLastName.Text = SelectedVolunteer.LastName;
            txtVolunteerCity.Text = SelectedVolunteer.VolunteerCity;
            txtVolunteerAddress.Text = SelectedVolunteer.VolunteerAddress;
            cBTransportNeeded.Checked = SelectedVolunteer.TransportNeeded;
        }

        private async void btnEditVolunteerDetails_Click(object sender, EventArgs e)
        {
            var editedDetails = new UpdateVolunteerAssignedToSchoolRequest
            {
                SchoolVolunteerId = SelectedVolunteer.SchoolVolunteerId,
                TransportNeeded = cBTransportNeeded.Checked
            };

            if(editedDetails != null)
            {
                await _apiServiceSchoolVolunteers.Update<ResponseResult>(editedDetails);
                MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
            }
            this.DialogResult = DialogResult.OK;
            Close();

            var principalForm = Application.OpenForms.OfType<frmVolunteerDetails>().FirstOrDefault();
            principalForm.frmVolunteerDetails_Load(sender, e);
        }
    }
}
