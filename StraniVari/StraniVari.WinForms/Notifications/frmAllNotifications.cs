 using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Notifications
{
    public partial class frmAllNotifications : Form
    {
        private readonly ApiService _apiService = new ApiService("Notifications");
        private readonly ApiService _apiServiceGet = new ApiService("Notifications/notifications");

        public EventUpsertRequest SelectedEvent { get; }
        public frmAllNotifications(EventUpsertRequest selectedEvent=null)
        {
            InitializeComponent();
            SelectedEvent = selectedEvent;
        }
        public async void frmAllNotifications_Load(object sender, EventArgs e)
        {
            dgvNotifications.AutoGenerateColumns = false;
            var result = await _apiServiceGet.GetById<List<GetMeetingsResponse>>(SelectedEvent.Id);
            dgvNotifications.DataSource = result;

            txtName.Text = SelectedEvent.Name;
            txtTheme.Text = SelectedEvent.StraniVariTheme;
            txtStartDate.Text = SelectedEvent.StartDate.ToString("D"); 
            txtEndDate.Text = SelectedEvent.EndDate.ToString("D"); 

        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            frmAddEditNotification frmAddEditNotification = new frmAddEditNotification(SelectedEvent);
            frmAddEditNotification.ShowDialog();
        }

        private async void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedNotification = dgvNotifications.SelectedRows[0].DataBoundItem as GetMeetingsResponse;
            if (selectedNotification != null)
            {
                if(e.ColumnIndex == 6)
                {
                    frmAddEditNotification frmAddEditNotification = new frmAddEditNotification(SelectedEvent,selectedNotification);
                    frmAddEditNotification.ShowDialog();
                }
                else if(e.ColumnIndex == 7)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmAllNotifications_Load(sender, e);
                    }
                    else
                    {
                        await _apiService.Delete<ResponseResult>(selectedNotification.Id);
                        frmAllNotifications_Load(sender, e);
                    }
                }
            }
        }
    }
}
