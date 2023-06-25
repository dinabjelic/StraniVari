using Newtonsoft.Json;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

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
                //if (e.ColumnIndex == 5)
                //{
                //    var editForm = new frmNewEvent(selectedEvent);
                //    if (editForm.ShowDialog() == DialogResult.OK)
                //    {
                //        frmAllEvents_Load(sender, e);
                //    }
                //}
                if (e.ColumnIndex == 5)
                {
                    frmEventTabs frmEventTabs = new frmEventTabs(selectedEvent);
                    frmEventTabs.ShowDialog();
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
                //else if (e.ColumnIndex == 7)
                //{
                //    var eventSchools = new frmShoolsForEvent(selectedEvent);
                //    eventSchools.ShowDialog();
                //}
                //else if (e.ColumnIndex == 8)
                //{
                //    frmAllNotifications frmAllNotifications = new frmAllNotifications(selectedEvent);
                //    frmAllNotifications.ShowDialog();
                //}
                //else if (e.ColumnIndex == 9)
                //{
                //    frmAllPlanAndProgramme frmAllPlanAndProgramme = new frmAllPlanAndProgramme(selectedEvent);
                //    frmAllPlanAndProgramme.ShowDialog();
                //}
                //else if (e.ColumnIndex == 10)
                //{
                //    frmAllApplications frmAllApplications = new frmAllApplications(selectedEvent);
                //    frmAllApplications.ShowDialog();
                //}
            }
        }

        private void dgvEvents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedEvent = JsonConvert.DeserializeObject<EventUpsertRequest>(dgvEvents.SelectedRows[0].DataBoundItem.ToString());
            if (selectedEvent != null)
            {
                var editForm = new frmNewEvent(selectedEvent);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    frmAllEvents_Load(sender, e);
                }
            }
        }
    }
}
