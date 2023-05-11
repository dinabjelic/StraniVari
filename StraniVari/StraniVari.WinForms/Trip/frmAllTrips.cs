using Newtonsoft.Json;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.EventDetails;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Trip
{
    public partial class frmAllTrips : Form
    {
        ApiService _apiService = new ApiService("Trip");

        public frmAllTrips()
        {
            InitializeComponent();
        }

        public async void frmAllTrips_Load(object sender, EventArgs e)
        {
            dgvTrip.AutoGenerateColumns = false;
            var result = await _apiService.Get<dynamic>();
            dgvTrip.DataSource = result;
        }

        private async void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedTrip = JsonConvert.DeserializeObject<GetTripResponse>(dgvTrip.SelectedRows[0].DataBoundItem.ToString());

            if (selectedTrip != null)
            {
                if (e.ColumnIndex == 3)
                {

                    frmAddEditTrip frmAddEditTrip = new frmAddEditTrip(selectedTrip);
                    frmAddEditTrip.ShowDialog();
                }
                else if (e.ColumnIndex == 4)
                {

                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmAllTrips_Load(sender, e);
                    }
                    else
                    {
                        await _apiService.Delete<ResponseResult>(selectedTrip.Id);
                        frmAllTrips_Load(sender, e);
                    }
                }
            }
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            frmAddEditTrip frmAddEditTrip = new frmAddEditTrip();
            frmAddEditTrip.ShowDialog();
        }
    }
}
