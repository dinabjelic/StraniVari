using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Volunteers
{
    public partial class frmAllVolunteers : Form
    {
        private readonly ApiService _apiService = new ApiService("Volunteers");
        public frmAllVolunteers()
        {
            InitializeComponent();
        }

        public async void frmAllVolunteers_Load(object sender, EventArgs e)
        {
            dgvVolunteers.AutoGenerateColumns = false;
            var result = await _apiService.Get<List<GetVolunteerDetailsResposne>>();
            dgvVolunteers.DataSource = result;
        }

        private async void dgvVolunteers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedVolunteer = dgvVolunteers.SelectedRows[0].DataBoundItem as GetVolunteerDetailsResposne;
            if (selectedVolunteer != null)
            {
                if (e.ColumnIndex == 5)
                {
                    frmAddEditVolunteer frmAddEditVolunteer = new frmAddEditVolunteer(selectedVolunteer);
                    frmAddEditVolunteer.ShowDialog();
                }
                else if (e.ColumnIndex == 6)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmAllVolunteers_Load(sender, e);
                    }
                    else
                    {
                        await _apiService.Delete<ResponseResult>(selectedVolunteer.Id);
                        frmAllVolunteers_Load(sender, e);
                    }
                }
            }
        }

        private void btnAddVolunteer_Click(object sender, EventArgs e)
        {
            frmAddEditVolunteer frmAddEditVolunteer = new frmAddEditVolunteer();
            frmAddEditVolunteer.ShowDialog();
        }
    }
}
