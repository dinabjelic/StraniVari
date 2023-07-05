using StraniVari.Common.Constants;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Trip
{
    public partial class frmAddEditTrip : Form
    {
        private readonly ApiService _apiService = new ApiService("Trip");
        private readonly ApiService _apiServiceDetails = new ApiService("Event/last-added-event");
        private GetTripResponse selectedTrip;
        public frmAddEditTrip(GetTripResponse selectedTrip = null)
        {
            InitializeComponent();
            this.selectedTrip = selectedTrip;
        }

        private async void btnTrip_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                var trip = new UpSertTripRequest
                {
                    Place = txtPlace.Text,
                    TripDateTime = dateTimePicker1.Value,
                    EventId = Convert.ToInt32(comboBox1.SelectedValue)
                };

                if (selectedTrip == null)
                {
                    await _apiService.Insert<ResponseResult>(trip);
                    MessageBox.Show("Trip successfully added.", "Infomation", MessageBoxButtons.OK);
                }
                else
                {
                    await _apiService.Update<ResponseResult>(trip, selectedTrip.Id);
                    MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }

            var principalForm = Application.OpenForms.OfType<frmTripTabs>().FirstOrDefault();
            principalForm.frmTripTabs_Load(sender, e);
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

        private async void frmAddEditTrip_Load(object sender, EventArgs e)
        {
            if (selectedTrip != null)
            {
                txtPlace.Text = selectedTrip.Place;
                dateTimePicker1.Value = selectedTrip.TripDateTime;
            }
            await LoadComboBoxValues();
        }

        private async Task LoadComboBoxValues()
        {
            var result = await _apiServiceDetails.Get<GetEventDetailsResponse>();
            comboBox1.DataSource = new List<GetEventDetailsResponse> { result };
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
