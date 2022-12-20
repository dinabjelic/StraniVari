using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Volunteers
{
    public partial class frmAddVolunteersToSchool : Form
    {
        private readonly ApiService _apiService = new ApiService("Volunteers");
        private readonly ApiService _apiServiceVolunteersSchool = new ApiService("SchoolVolunteers");
        public GetSchoolsForEventResponse _selectedSchool { get; }
        public EventUpsertRequest _selectedEvent { get; }
       
        public frmAddVolunteersToSchool(GetSchoolsForEventResponse selectedSchool, EventUpsertRequest selectedEvent)
        {
            InitializeComponent();
            _selectedSchool = selectedSchool;
            _selectedEvent = selectedEvent;
        }

        private async void frmAddVolunteersToSchool_Load(object sender, EventArgs e)
        {
            await LoadEventDetails();
            await LoadTextBoxValues();
        }

        private async Task LoadTextBoxValues()
        {
            var volunteers = await _apiService.Get<List<GetVolunteerDetailsResposne>>();
            lbxVolunteers.DataSource = volunteers;
            lbxVolunteers.ValueMember = "Id";
            lbxVolunteers.DisplayMember = "FirstName";
        }

        private async Task LoadEventDetails()
        {
            txtName.Text = _selectedEvent.Name;
            txtTheme.Text = _selectedEvent.StraniVariTheme;
            txtStartDate.Text = _selectedEvent.StartDate.ToString("D");
            txtEndDate.Text = _selectedEvent.EndDate.ToString("D");
            txtSchool.Text = _selectedSchool.SchoolName;
        }

        private async void btnAddVolunteersToSchool_Click(object sender, EventArgs e)
        {
            var volunteers = new InsertVolunteerToSchoolRequest
            {
                EventSchoolId = _selectedSchool.SchoolEventId,
                Volunteers = lbxVolunteers.SelectedItems.Cast<GetVolunteerDetailsResposne>()
                .Select(x => x.Id).ToArray()
            };

            if (volunteers != null)
            {
                MessageBox.Show("Selected volunteers will be added to school.", "Infomation", MessageBoxButtons.OK);
                await _apiServiceVolunteersSchool.Insert<ResponseResult>(volunteers);
                MessageBox.Show("Volunteers successfully added.", "Infomation", MessageBoxButtons.OK);
            }

            frmVolunteerDetails frmVolunteerDetails = new frmVolunteerDetails(_selectedSchool, _selectedEvent);
            frmVolunteerDetails.Show();
        }
    }
}
