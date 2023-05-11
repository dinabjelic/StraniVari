using Newtonsoft.Json;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.EventDetails;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Applications
{
    public partial class frmAllApplications : Form
    {
        ApiService _apiServiceDetails = new ApiService("Trip/details");
        ApiService _apiService = new ApiService("VolunteerTrip/details");

        public EventUpsertRequest SelectedEvent { get; }
        public frmAllApplications(EventUpsertRequest selectedEvent)
        {
            InitializeComponent();
            SelectedEvent = selectedEvent;
        }

        public async void frmAllApplications_Load(object sender, EventArgs e)
        {
            dgvApplications.AutoGenerateColumns = false;
            var result = await _apiService.GetById<List<GetTripApplicationsResponse>>(SelectedEvent.Id);
            dgvApplications.DataSource = result;

            var tripDetails = await _apiServiceDetails.GetById<List<GetTripsDetailsForEventResponse>>(SelectedEvent.Id);

            txtName.Text = SelectedEvent.Name;
            txtTheme.Text = SelectedEvent.StraniVariTheme;
            txtStartDate.Text = SelectedEvent.StartDate.ToString("D");
            txtEndDate.Text = SelectedEvent.EndDate.ToString("D");

            if (tripDetails.Count > 0)
            {
                txtTripPlace.Text = tripDetails[0].Place;
                txtTripDatTime.Text = tripDetails[0].TripDateTime.ToString("D");
            }
        }

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var selectedVolunteer = JsonConvert.DeserializeObject<List<GetTripApplicationsResponse>>(dgvApplications.SelectedRows[0].DataBoundItem.ToString());
            var selectedVolunteer = dgvApplications.SelectedRows[0].DataBoundItem as GetTripApplicationsResponse;

            if (selectedVolunteer != null)
            {
                if (e.ColumnIndex == 4)
                {
                    var editForm = new frmEditApplication(SelectedEvent, selectedVolunteer);
                    editForm.ShowDialog();
                }
            }
        }
    }
}
