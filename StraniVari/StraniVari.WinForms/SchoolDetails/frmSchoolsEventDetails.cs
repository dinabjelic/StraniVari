using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Material;
using StraniVari.WinUI.Service;
using StraniVari.WinUI.Volunteers;

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

        public async void frmSchoolsEventDetails_Load(object sender, EventArgs e)
        {
            dgvSchoolsEventDetails.AutoGenerateColumns = false;
            var result = await _apiService.GetById<List<GetSchoolsForEventResponse>>(_selectedEvent.Id);
            dgvSchoolsEventDetails.DataSource = result;
            await LoadEventDetails();
        }

        private async Task LoadEventDetails()
        {
            txtName.Text = _selectedEvent.Name;
            txtTheme.Text = _selectedEvent.StraniVariTheme;
            txtStartDate.Text = _selectedEvent.StartDate.ToString("D");
            txtEndDate.Text = _selectedEvent.EndDate.ToString("D");
        }

        private async void dgvSchoolsEventDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var selectedSchool = dgvSchoolsEventDetails.SelectedRows[0].DataBoundItem as GetSchoolsForEventResponse;
            Text = e.ColumnIndex.ToString();
            if (selectedSchool != null)
            {
                if (e.ColumnIndex == 5)
                {
                    frmEditSchoolsDetails frmEditSchoolsDetails = new frmEditSchoolsDetails(selectedSchool, _selectedEvent);
                    frmEditSchoolsDetails.ShowDialog();
                }
                else if(e.ColumnIndex ==6)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmSchoolsEventDetails_Load(sender, e);
                    }
                    else
                    {
                        await _apiService.Delete<ResponseResult>(selectedSchool.SchoolEventId);
                        frmSchoolsEventDetails_Load(sender, e);
                    }
                }
                else if(e.ColumnIndex == 7)
                {
                    frmAddMaterialToSchool frmAddMaterialToSchool = new frmAddMaterialToSchool(selectedSchool, _selectedEvent);
                    frmAddMaterialToSchool.ShowDialog();
                }
                else if(e.ColumnIndex == 8)
                {
                    frmAddVolunteersToSchool frmAddVolunteersToSchool = new frmAddVolunteersToSchool(selectedSchool, _selectedEvent);
                    frmAddVolunteersToSchool.ShowDialog();
                }
            }
        }
    }
}
