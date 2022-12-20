﻿using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Volunteers
{
    public partial class frmVolunteerDetails : Form
    {
        private readonly ApiService _apiService = new ApiService("SchoolVolunteers");
        public GetSchoolsForEventResponse _selectedSchool { get; }
        public EventUpsertRequest _selectedEvent { get; }

        public frmVolunteerDetails(GetSchoolsForEventResponse selectedSchool, EventUpsertRequest selectedEvent)
        {
            InitializeComponent();
            _selectedSchool = selectedSchool;
            _selectedEvent = selectedEvent;
        }

        public async void frmVolunteerDetails_Load(object sender, EventArgs e)
        {
            dgvVolunteers.AutoGenerateColumns = false;
            var result = await _apiService.GetById<List<GetVolunteersForSchoolResponse>>(_selectedSchool.SchoolEventId);
            dgvVolunteers.DataSource = result;
            await LoadEventDetails();
        }

        private async Task LoadEventDetails()
        {
            txtName.Text = _selectedEvent.Name;
            txtTheme.Text = _selectedEvent.StraniVariTheme;
            txtStartDate.Text = _selectedEvent.StartDate.ToString("D");
            txtEndDate.Text = _selectedEvent.EndDate.ToString("D");
            txtSchool.Text = _selectedSchool.SchoolName;
        }

        private async void dgvMaterialForSchool_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedVolunteer = dgvVolunteers.SelectedRows[0].DataBoundItem as GetVolunteersForSchoolResponse;

            if (selectedVolunteer != null)
            {
                if(e.ColumnIndex == 6)
                {
                    frmEditVolunteerDetails frmEditVolunteerDetails = new frmEditVolunteerDetails(selectedVolunteer, _selectedEvent, _selectedSchool);
                    frmEditVolunteerDetails.Show();
                }
                else if(e.ColumnIndex == 7)
                {
                    MessageBox.Show("You are about to delete this item!");
                    await _apiService.Delete<ResponseResult>(selectedVolunteer.SchoolVolunteerId);
                    frmVolunteerDetails_Load(sender, e);
                }
            }
        }
    }
}
