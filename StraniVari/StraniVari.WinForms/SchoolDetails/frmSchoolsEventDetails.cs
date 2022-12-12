using Newtonsoft.Json;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmSchoolsEventDetails : Form
    {
        private readonly ApiService _apiService = new ApiService("EventSchool");
        ApiService _apiServiceEvent = new ApiService("Event/event-details");
        public EventUpsertRequest _selectedEvent { get; }

        public frmSchoolsEventDetails(EventUpsertRequest selectedEvent=null)
        {
            InitializeComponent();
            _selectedEvent = selectedEvent;
        }

        private async void frmSchoolsEventDetails_Load(object sender, EventArgs e)
        {
            var result = await _apiService.GetById<List<GetSchoolsForEventResponse>>(_selectedEvent.Id);
            dgvSchoolsEventDetails.DataSource = result;
            //this.DialogResult = DialogResult.OK;
            await LoadTextBoxValues();
        }

        private async Task LoadTextBoxValues()
        {
            var eventDetails = await _apiServiceEvent.GetById<List<GetEventDetailsByIdResponse>>(_selectedEvent.Id);
            txtName.Text = eventDetails[0].Name;
            txtTheme.Text = eventDetails[0].StraniVariTheme;
            txtStartDate.Text = eventDetails[0].StartDate.ToString("D");
            txtEndDate.Text = eventDetails[0].EndDate.ToString("D");
        }

        private void dgvSchoolsEventDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var selectedElement = JsonConvert.DeserializeObject<EventSchoolUpdateRequest>(dgvSchoolsEventDetails.SelectedRows[0].DataBoundItem.ToString());

            if (selectedElement != null)
            {
                if (e.ColumnIndex == 4)
                {
                    frmEditSchoolsDetails frmEditSchoolsDetails = new frmEditSchoolsDetails(selectedElement);
                    frmEditSchoolsDetails.Show();
                }
            }
        }
    }
}
