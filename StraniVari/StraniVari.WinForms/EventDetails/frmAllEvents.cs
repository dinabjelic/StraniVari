using Newtonsoft.Json;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Games;
using StraniVari.WinUI.Material;
using StraniVari.WinUI.Notifications;
using StraniVari.WinUI.PlanAndProgramme;
using StraniVari.WinUI.Reports;
using StraniVari.WinUI.SchoolDetails;
using StraniVari.WinUI.Service;
using StraniVari.WinUI.Volunteers;

namespace StraniVari.WinUI.EventDetails
{
    public partial class frmAllEvents : Form
    {
        private readonly ApiService _apiService = new ApiService("Event");
        public frmAllEvents()
        {
            InitializeComponent();
        }

        private async void frmAllEvents_Load(object sender, EventArgs e)
        {
            dgvEvents.AutoGenerateColumns = false;
            var result = await _apiService.Get<dynamic>();
            dgvEvents.DataSource = result;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            frmNewEvent newEvent = new frmNewEvent();
            if (newEvent.ShowDialog() == DialogResult.OK)
            {
                frmAllEvents_Load(sender, e);
            }
        }

        private async void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var selectedEvent = dgvEvents.SelectedRows[0].DataBoundItem;

            var selectedEvent = JsonConvert.DeserializeObject<EventUpsertRequest>(dgvEvents.SelectedRows[0].DataBoundItem.ToString());
            if (selectedEvent != null)
            {
                if (e.ColumnIndex == 5)
                {
                    var editForm = new frmNewEvent(selectedEvent);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        frmAllEvents_Load(sender, e);
                    }
                }
                else if (e.ColumnIndex == 6)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmAllEvents_Load(sender, e);
                    }
                    else
                    {
                       await _apiService.Delete<ResponseResult>(selectedEvent.Id);
                       frmAllEvents_Load(sender, e);
                    }
                }
                else if(e.ColumnIndex == 7)
                {
                    var eventSchools = new frmShoolsForEvent(selectedEvent);
                    eventSchools.ShowDialog();
                }
                else if(e.ColumnIndex == 8)
                {
                    frmAllNotifications frmAllNotifications = new frmAllNotifications(selectedEvent);
                    frmAllNotifications.ShowDialog();
                }
                else if(e.ColumnIndex == 9)
                {
                    frmAllPlanAndProgramme frmAllPlanAndProgramme = new frmAllPlanAndProgramme(selectedEvent);
                    frmAllPlanAndProgramme.ShowDialog();
                }
            }
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            frmAllMaterial frmAllMaterial = new frmAllMaterial();
            frmAllMaterial.ShowDialog();
        }

        private void btnVolunteers_Click(object sender, EventArgs e)
        {
            frmAllVolunteers frmAllVolunteers = new frmAllVolunteers();
            frmAllVolunteers.ShowDialog();
        }

        private void btnSchools_Click(object sender, EventArgs e)
        {
            frmAllSchools frmAllSchools = new frmAllSchools();
            frmAllSchools.ShowDialog();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            frmAllGames frmAllGames = new frmAllGames();
            frmAllGames.ShowDialog();
        }
    }
}
