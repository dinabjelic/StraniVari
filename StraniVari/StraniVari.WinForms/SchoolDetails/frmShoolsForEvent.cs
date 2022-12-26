using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmShoolsForEvent : Form
    {
        ApiService _apiService = new ApiService("Schools");
        ApiService _apiServiceEventSchool = new ApiService("EventSchool");
        public EventUpsertRequest _selectedEvent { get; }
        List<GetSchoolDetailsResponse> schools = new List<GetSchoolDetailsResponse>();
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
            txtName.Text = _selectedEvent.Name;
            txtTheme.Text = _selectedEvent.StraniVariTheme;
            txtStartDate.Text = _selectedEvent.StartDate.ToString("D");
            txtEndDate.Text = _selectedEvent.EndDate.ToString("D");
        }
        private async Task LoadTextBoxValues()
        {
            schools = await _apiService.Get<List<GetSchoolDetailsResponse>>();
            lbxSchools.DataSource = schools;
            lbxSchools.ValueMember = "Id";
            lbxSchools.DisplayMember = "Name";

        }

        private async void btnAddSchoolToEvent_Click(object sender, EventArgs e)
        {
            var schoolsForEvent = await _apiServiceEventSchool.GetById<List<GetSchoolsForEventResponse>>(_selectedEvent.Id);

            var straniVariEvent = new EventSchoolInsertRequest
            {
                EventId = _selectedEvent.Id,
                Schools = lbxSchools.SelectedItems.Cast<GetSchoolDetailsResponse>()
                .Select(x => x.Id)
                .ToArray()
            };

            bool added = false;
            foreach(var item in schoolsForEvent)
            {
                foreach(var i in straniVariEvent.Schools)
                {
                    if(item.SchoolId == i)
                    {
                        added = true;
                        break;
                    }
                }
            }
            if(!added)
            {
                if (straniVariEvent != null)
                {
                    await _apiServiceEventSchool.Insert<ResponseResult>(straniVariEvent);
                    MessageBox.Show("Schools successfully added.", "Infomation", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("You cannot add duplicate schools to the same event.", "Infomation", MessageBoxButtons.OK);
                Close();
            }

            frmSchoolsEventDetails frmSchoolsEventDetails = new frmSchoolsEventDetails(_selectedEvent);
            frmSchoolsEventDetails.ShowDialog();
        }

        private void lbxSchools_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = lbxSchools.SelectedItems.Count.ToString();
        }
    }
}
