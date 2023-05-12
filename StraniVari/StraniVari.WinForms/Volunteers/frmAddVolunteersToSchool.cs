using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Volunteers
{
    public partial class frmAddVolunteersToSchool : Form
    {
        private readonly ApiService _apiService = new ApiService("Volunteers");
        private readonly ApiService _apiServiceVolunteersSchool = new ApiService("SchoolVolunteers");
        private readonly ApiService _apiServiceVolunteersSchoolDetails = new ApiService("SchoolVolunteers/get");

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
            var volunteersForSchool = await _apiServiceVolunteersSchoolDetails.GetById<List<GetVolunteersForSchoolResponse>>(_selectedSchool.SchoolEventId);
            var volunteers = new InsertVolunteerToSchoolRequest
            {
                EventSchoolId = _selectedSchool.SchoolEventId,
                Volunteers = lbxVolunteers.SelectedItems.Cast<GetVolunteerDetailsResposne>()
                .Select(x => x.Id).ToArray()
            };


            bool added = false;
            foreach(var item in volunteersForSchool)
            {
                foreach(var i in volunteers.Volunteers)
                {
                    if (item.VolunteerId == i)
                    {
                        added = true;
                        break;
                    }
                }
            }

            if (!added) {
                await _apiServiceVolunteersSchool.Insert<ResponseResult>(volunteers);
                MessageBox.Show("Volunteers successfully added.", "Infomation", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You cannot add duplicate volunteer to the same school.", "Infomation", MessageBoxButtons.OK);
                Close();
            }

            frmVolunteerDetails frmVolunteerDetails = new frmVolunteerDetails(_selectedSchool, _selectedEvent);
            frmVolunteerDetails.ShowDialog();
        }

        private void lbxVolunteers_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = lbxVolunteers.SelectedItems.Count.ToString();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmVolunteerDetails frmVolunteerDetails = new frmVolunteerDetails(_selectedSchool, _selectedEvent);
            frmVolunteerDetails.ShowDialog();
        }
    }
}
