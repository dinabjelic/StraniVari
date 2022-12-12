using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmShoolsForEvent : Form
    {
        ApiService _apiService = new ApiService("Schools");
        ApiService _apiServiceEvent = new ApiService("Event/event-details");
        ApiService _apiServiceEventSchool = new ApiService("EventSchool");
        public EventUpsertRequest _selectedEvent { get; }
        public frmShoolsForEvent(EventUpsertRequest selectedEvent = null)
        {
            InitializeComponent();
            _selectedEvent = selectedEvent;

        }

        private async void frmShoolsForEvent_Load(object sender, EventArgs e)
        {
            await LoadTextBoxValues();
            await LoadEventDetails();
        }

        private async Task LoadEventDetails()
        {
            var eventDetails = await _apiServiceEvent.GetById<List<GetEventDetailsByIdResponse>>(_selectedEvent.Id);
            txtName.Text = eventDetails[0].Name;
            txtTheme.Text = eventDetails[0].StraniVariTheme;
            txtStartDate.Text = eventDetails[0].StartDate.ToString("D");
            txtEndDate.Text = eventDetails[0].EndDate.ToString("D");
        }
        private async Task LoadTextBoxValues()
        {
            var schools = await _apiService.Get<List<GetSchoolDetailsResponse>>();
            lbxSchools.DataSource = schools;
            lbxSchools.ValueMember = "Id";
            lbxSchools.DisplayMember = "Name";
        }

        private async void btnAddSchoolToEvent_Click(object sender, EventArgs e)
        {

            var straniVariEvent = new EventSchoolInsertRequest
            {
                EventId = _selectedEvent.Id,
                Schools = lbxSchools.SelectedItems.Cast<GetSchoolDetailsResponse>()
                .Select(x => x.Id)
                .ToArray()
            };

            if (straniVariEvent != null)
            {
                MessageBox.Show("Selected schools will be added to event.", "Infomation", MessageBoxButtons.OK);
                await _apiServiceEventSchool.Insert<ResponseResult>(straniVariEvent);
                MessageBox.Show("Schools successfully added.", "Infomation", MessageBoxButtons.OK);
            }

            frmSchoolsEventDetails frmSchoolsEventDetails = new frmSchoolsEventDetails(_selectedEvent);
            frmSchoolsEventDetails.Show();
        }
    }
}
