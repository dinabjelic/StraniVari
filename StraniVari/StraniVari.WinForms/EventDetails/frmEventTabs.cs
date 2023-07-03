using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Applications;
using StraniVari.WinUI.Notifications;
using StraniVari.WinUI.PlanAndProgramme;
using StraniVari.WinUI.SchoolDetails;
using StraniVari.WinUI.Service;
using System.Xml.Linq;

namespace StraniVari.WinUI.EventDetails
{
    public partial class frmEventTabs : Form
    {
        ApiService _apiService = new ApiService("PlanAndProgramme/planAndProgramme");
        ApiService _apiServiceDelete = new ApiService("PlanAndProgramme");
        ApiService _apiServiceGet = new ApiService("Notifications/notifications");
        ApiService _apiServiceNotification = new ApiService("Notifications");
        ApiService _apiServiceApplicationsDetails = new ApiService("Trip/get");
        ApiService _apiServiceVolunteerTrips = new ApiService("VolunteerTrip/get");
        ApiService _apiServiceEventSchoolGet = new ApiService("EventSchool/get");
        ApiService _apiServiceEventSchools = new ApiService("EventSchool");


        private EventUpsertRequest selectedEvent;

        public frmEventTabs(EventUpsertRequest selectedEvent)
        {
            this.selectedEvent = selectedEvent;
            InitializeComponent();
        }

        private void frmEventTabs_Load(object sender, EventArgs e)
        {
            frmAllPlanAndProgramme_Load(sender, e);
            frmAllNotifications_Load(sender, e);
            frmAllApplications_Load(sender, e);
            frmSchoolsEventDetails_Load(sender, e);
        }

        public async void frmAllPlanAndProgramme_Load(object sender, EventArgs e)
        {
            dgvPlanAndProgramme.AutoGenerateColumns = false;
            var result = await _apiService.GetById<List<GetPlanAndProgrameResposnse>>(selectedEvent.Id);
            dgvPlanAndProgramme.DataSource = result;
        }

        public async void frmAllNotifications_Load(object sender, EventArgs e)
        {
            dgvNotifications.AutoGenerateColumns = false;
            var result = await _apiServiceGet.GetById<List<GetMeetingsResponse>>(selectedEvent.Id);
            dgvNotifications.DataSource = result;
        }
        public async void frmAllApplications_Load(object sender, EventArgs e)
        {
            dgvApplications.AutoGenerateColumns = false;
            var result = await _apiServiceVolunteerTrips.GetById<List<GetTripApplicationsResponse>>(selectedEvent.Id);
            dgvApplications.DataSource = result;

            var tripDetails = await _apiServiceApplicationsDetails.GetById<List<GetTripsDetailsForEventResponse>>(selectedEvent.Id);
        }

        public async void frmSchoolsEventDetails_Load(object sender, EventArgs e)
        {
            dgvSchoolsEventDetails.AutoGenerateColumns = false;
            var result = await _apiServiceEventSchoolGet.GetById<List<GetSchoolsForEventResponse>>(selectedEvent.Id);
            dgvSchoolsEventDetails.DataSource = result;
        }

        private async void dgvPlanAndProgramme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedPlan = dgvPlanAndProgramme.SelectedRows[0].DataBoundItem as GetPlanAndProgrameResposnse;

            if (selectedPlan != null)
            {
                if (e.ColumnIndex == 3)
                {
                    frmActivities frmActivities = new frmActivities(selectedPlan, selectedEvent);
                    frmActivities.ShowDialog();
                }
                else if (e.ColumnIndex == 4)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmAllPlanAndProgramme_Load(sender, e);
                    }
                    else
                    {
                        await _apiServiceDelete.Delete<ResponseResult>(selectedPlan.Id);
                        frmAllPlanAndProgramme_Load(sender, e);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProgramme frmAddEditProgramme = new frmAddEditProgramme(selectedEvent);
            frmAddEditProgramme.ShowDialog();
        }

        private void dgvPlanAndProgramme_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedPlan = dgvPlanAndProgramme.SelectedRows[0].DataBoundItem as GetPlanAndProgrameResposnse;

            if (selectedPlan != null)
            {
                frmAddEditProgramme frmAddEditProgramme = new frmAddEditProgramme(selectedEvent, selectedPlan);
                frmAddEditProgramme.ShowDialog();
            }
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            frmAddEditNotification frmAddEditNotification = new frmAddEditNotification(selectedEvent);
            frmAddEditNotification.ShowDialog();
        }

        private async void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedNotification = dgvNotifications.SelectedRows[0].DataBoundItem as GetMeetingsResponse;
            if (selectedNotification != null)
            {
                if (e.ColumnIndex == 6)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmAllNotifications_Load(sender, e);
                    }
                    else
                    {
                        await _apiServiceNotification.Delete<ResponseResult>(selectedNotification.Id);
                        frmAllNotifications_Load(sender, e);
                    }
                }
            }
        }

        private void dgvNotifications_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedNotification = dgvNotifications.SelectedRows[0].DataBoundItem as GetMeetingsResponse;
            if (selectedNotification != null)
            {
                frmAddEditNotification frmAddEditNotification = new frmAddEditNotification(selectedEvent, selectedNotification);
                frmAddEditNotification.ShowDialog();
            }
        }

        private void dgvApplications_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedVolunteer = dgvApplications.SelectedRows[0].DataBoundItem as GetTripApplicationsResponse;
            if (selectedVolunteer != null)
            {
                var editForm = new frmEditApplication(selectedEvent, selectedVolunteer);
                editForm.ShowDialog();
            }
        }

        private async void dgvSchoolsEventDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedSchool = dgvSchoolsEventDetails.SelectedRows[0].DataBoundItem as GetSchoolsForEventResponse;
            if (selectedSchool != null)
            {
                if (e.ColumnIndex == 5)
                {
                    frmSchoolTabs frmSchoolTabs = new frmSchoolTabs(selectedSchool);
                    frmSchoolTabs.ShowDialog();
                }
                else if (e.ColumnIndex == 6)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmSchoolsEventDetails_Load(sender, e);
                    }
                    else
                    {
                        await _apiServiceEventSchools.Delete<ResponseResult>(selectedSchool.SchoolEventId);
                        frmSchoolsEventDetails_Load(sender, e);
                    }
                }
            }
        }

        private void dgvSchoolsEventDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedSchool = dgvSchoolsEventDetails.SelectedRows[0].DataBoundItem as GetSchoolsForEventResponse;
            if (selectedSchool != null)
            {
                frmEditSchoolsDetails frmEditSchoolsDetails = new frmEditSchoolsDetails(selectedSchool);
                frmEditSchoolsDetails.ShowDialog();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            frmSchoolsMaterialVolunteerscs frmSchoolsMaterialVolunteerscs = new frmSchoolsMaterialVolunteerscs(selectedEvent);
            frmSchoolsMaterialVolunteerscs.ShowDialog();
        }
    }
}
