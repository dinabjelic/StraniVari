using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Notifications
{
    public partial class frmAddEditNotification : Form
    {
        private readonly ApiService _apiService = new ApiService("Notifications");
        public EventUpsertRequest SelectedEvent { get; }
        public GetMeetingsResponse SelectedNotification { get; }

        public frmAddEditNotification(EventUpsertRequest selectedEvent = null,GetMeetingsResponse selectedNotification=null)
        {
            InitializeComponent();
            SelectedNotification = selectedNotification;
            SelectedEvent = selectedEvent;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var notification = new UpSertMeetingRequest
            {
                MeetingDate = dateTimePicker1.Value,
                Address = txtAddress.Text,
                City = txtCity.Text,
                MeetingPlace = txtMeetingPlace.Text,
                MeetingTheme = txtMeetingTheme.Text, 
                EventId = SelectedEvent.Id, 
            };

            if (SelectedNotification == null)
            {
                await _apiService.Insert<ResponseResult>(notification);
                MessageBox.Show("Notification successfully added.", "Infomation", MessageBoxButtons.OK);
            }
            else
            {
                await _apiService.Update<ResponseResult>(notification, SelectedNotification.Id);
                MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
            }
            this.DialogResult = DialogResult.OK;
            Close();

            var principalForm = Application.OpenForms.OfType<frmAllNotifications>().FirstOrDefault();
            principalForm.frmAllNotifications_Load(sender, e);
        }

        private void frmAddEditNotification_Load(object sender, EventArgs e)
        {
            if(SelectedNotification != null)
            {
                txtAddress.Text = SelectedNotification.Address;
                txtCity.Text = SelectedNotification.City;
                txtMeetingPlace.Text = SelectedNotification.MeetingPlace;
                txtMeetingTheme.Text = SelectedNotification.MeetingTheme;
                dateTimePicker1.Value = SelectedNotification.MeetingDate;
            }
        }
    }
}
