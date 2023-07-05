using Newtonsoft.Json;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;
using System.IdentityModel.Tokens.Jwt;

namespace StraniVari.WinUI.Trip
{
    public partial class frmTripTabs : Form
    {
        ApiService _apiService = new ApiService("Trip");
        public frmTripTabs()
        {
            InitializeComponent();
        }

        public async void frmTripTabs_Load(object sender, EventArgs e)
        {


            dgvTrip.AutoGenerateColumns = false;
            var result = await _apiService.Get<dynamic>();
            dgvTrip.DataSource = result;
        }

        private async void dgvTrip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedTrip = JsonConvert.DeserializeObject<GetTripResponse>(dgvTrip.SelectedRows[0].DataBoundItem.ToString());

            if (selectedTrip != null)
            {
                if (e.ColumnIndex == 3)
                {

                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmTripTabs_Load(sender, e);
                    }
                    else
                    {
                        await _apiService.Delete<ResponseResult>(selectedTrip.Id);
                        frmTripTabs_Load(sender, e);
                    }
                }
            }
        }

        private async void dgvTrip_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedTrip = JsonConvert.DeserializeObject<GetTripResponse>(dgvTrip.SelectedRows[0].DataBoundItem.ToString());

            if (selectedTrip != null)
            {
                frmEditTrip frmEditTrip = new frmEditTrip(selectedTrip);
                frmEditTrip.ShowDialog();
            }
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            frmAddEditTrip frmAddEditTrip = new frmAddEditTrip();
            frmAddEditTrip.ShowDialog();
        }
    }
}
