using StraniVari.Common.Constants;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Trip
{
    public partial class frmEditTrip : Form
    {
        private readonly ApiService _apiService = new ApiService("Trip");
        public GetTripResponse SelectedTrip { get; }
        public frmEditTrip(GetTripResponse selectedTrip)
        {
            InitializeComponent();
            SelectedTrip = selectedTrip;
        }

        private bool ValidateEntry()
        {
            return ValidateControl(txtPlace, Constants.RequiredValue);
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

        private async void btnTrip_Click_1(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                var trip = new UpdateTripRequest
                {
                    Id = SelectedTrip.Id,
                    Place = txtPlace.Text,
                    TripDateTime = dateTimePicker1.Value,
                };

                await _apiService.Update<ResponseResult>(trip, SelectedTrip.Id);
                MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                Close();
            }

            var principalForm = Application.OpenForms.OfType<frmTripTabs>().FirstOrDefault();
            principalForm.frmTripTabs_Load(sender, e);
        }

        private void frmEditTrip_Load_1(object sender, EventArgs e)
        {
            if (SelectedTrip != null)
            {
                txtPlace.Text = SelectedTrip.Place;
                dateTimePicker1.Value = SelectedTrip.TripDateTime;
            }
        }
    }
}
