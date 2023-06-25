using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.EventDetails;
using StraniVari.WinUI.Games;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Applications
{
    public partial class frmEditApplication : Form
    {
        ApiService _apiServiceDetails = new ApiService("Trip/get");
        ApiService _apiService = new ApiService("TripStatus");
        ApiService _apiServiceVolunteerTrip = new ApiService("VolunteerTrip");


        public EventUpsertRequest SelectedEvent { get; }
        public GetTripApplicationsResponse SelectedVolunteer { get; }
        public frmEditApplication(EventUpsertRequest selectedEvent, GetTripApplicationsResponse selectedVolunteer)
        {
            InitializeComponent();
            SelectedEvent = selectedEvent;
            SelectedVolunteer = selectedVolunteer;
        }

        private async void frmEditApplication_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<GetStatusResponse>>();
            comboBox1.DataSource = result;
            comboBox1.DisplayMember = "Status";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedValue = SelectedVolunteer.StatusId;
            var tripDetails = await _apiServiceDetails.GetById<List<GetTripsDetailsForEventResponse>>(SelectedEvent.Id);

            txtFristName.Text = SelectedVolunteer.VolunteerName;
            txtLastName.Text = SelectedVolunteer.VolunteerLastName;
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            var status = new VolunteerTripUpdateRequest
            {
                StatusId = int.Parse(comboBox1.SelectedValue.ToString())
            };

            await _apiServiceVolunteerTrip.Update<ResponseResult>(status, SelectedVolunteer.Id);
            MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
            Close();

            var principalForm = Application.OpenForms.OfType<frmEventTabs>().FirstOrDefault();
            principalForm.frmAllApplications_Load(sender, e);
        }
    }
}
