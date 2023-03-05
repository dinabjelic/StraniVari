using StraniVari.Common.Constants;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.EventDetails
{
    public partial class frmNewEvent : Form
    {
        ApiService _apiService = new ApiService("Event");
        private EventUpsertRequest selectedEvent;
        EventUpsertRequest request = new EventUpsertRequest();
       
        public frmNewEvent(EventUpsertRequest selectedEvent=null)
        {
            InitializeComponent();
            this.selectedEvent = selectedEvent;
        }

        private async void btnAddNewEvent_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                var straniVariEvent = new EventUpsertRequest
                {
                    Name = txtEventName.Text,
                    StraniVariTheme = txtStraniVariTheme.Text,
                    StartDate = dtpStarDate.Value,
                    EndDate = dtpEndDate.Value
                };

                if (selectedEvent == null)
                {
                    await _apiService.Insert<ResponseResult>(straniVariEvent);
                    //if(result is not null)
                    //{
                        MessageBox.Show("Event successfully added.", "Infomation", MessageBoxButtons.OK);
                    //}
                }
                else
                {
                    await _apiService.Update<ResponseResult>(straniVariEvent, selectedEvent.Id);
                    //if(result is not null)
                    //{
                        MessageBox.Show("Event successfully updated.", "Infomation", MessageBoxButtons.OK);
                    //}
                }

            this.DialogResult = DialogResult.OK;
            Close();
            }
        }

        private void frmNewEvent_Load(object sender, EventArgs e)
        {
            if (selectedEvent != null)
            {
                txtEventName.Text = selectedEvent.Name;
                txtStraniVariTheme.Text = selectedEvent.StraniVariTheme;
                dtpStarDate.Value = selectedEvent.StartDate;
                dtpEndDate.Value = selectedEvent.EndDate;

            }
        }

        private bool ValidateEntry()
        {
            return ValidateControl(txtEventName, Constants.RequiredValue) &&
                   ValidateControl(txtStraniVariTheme, Constants.RequiredValue);
        }

        private bool ValidateControl(Control control, string message)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                err.SetError(control, message);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
