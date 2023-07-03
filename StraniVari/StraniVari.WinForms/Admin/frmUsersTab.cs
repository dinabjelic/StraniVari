using StraniVari.Core.Entities;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Helpers;
using StraniVari.WinUI.Service;
using StraniVari.WinUI.Volunteers;

namespace StraniVari.WinUI.Admin
{
    public partial class frmUsersTab : Form
    {
        private readonly ApiService _apiServiceVolunters = new ApiService("Volunteers");
        private readonly ApiService _apiServiceAdmin = new ApiService("Administrator");
        private readonly ApiService _apiServiceFilteredAdmin = new ApiService("Administrator/filtered-data");
        private readonly ApiService _apiServiceFilteredVolunteer = new ApiService("Volunteers/filtered-data");


        public frmUsersTab()
        {
            InitializeComponent();
        }

        private async void frmUsersTab_Load(object sender, EventArgs e)
        {
            frmAllAdmins_Load(sender, e);
            frmAllVolunteers_Load(sender, e);
        }

        public async void frmAllVolunteers_Load(object sender, EventArgs e)
        {
            dgvVolunteers.AutoGenerateColumns = false;
            var result = await _apiServiceVolunters.Get<List<GetVolunteerDetailsResposne>>();
            dgvVolunteers.DataSource = result;
        }

        public async void frmAllAdmins_Load(object sender, EventArgs e)
        {
            dgvAdmins.AutoGenerateColumns = false;
            var result = await _apiServiceAdmin.Get<List<GetAdministratorDetailsResponse>>();
            dgvAdmins.DataSource = result;
        }
        private void btnAddVolunteer_Click(object sender, EventArgs e)
        {
            frmAddEditVolunteer frmAddEditVolunteer = new frmAddEditVolunteer();
            frmAddEditVolunteer.ShowDialog();
        }

        private async void dgvAdmins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedAdmin = dgvAdmins.SelectedRows[0].DataBoundItem as GetAdministratorDetailsResponse;
            if (selectedAdmin != null)
            {
                if (e.ColumnIndex == 5)
                {
                    if (selectedAdmin.Id.ToString() == JWTIdDecoder.ShowId())
                    {
                        MessageBox.Show("You cannot delete yourself!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmation == DialogResult.No)
                        {
                            frmAllVolunteers_Load(sender, e);
                        }
                        else
                        {
                            await _apiServiceAdmin.Delete<ResponseResult>(selectedAdmin.Id);
                            frmAllAdmins_Load(sender, e);
                        }
                    }

                }

            }

        }

        private void dgvAdmins_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedAdmin = dgvAdmins.SelectedRows[0].DataBoundItem as GetAdministratorDetailsResponse;
            if (selectedAdmin != null)
            {
                frmAddEditAdminstrator frmAddEditVolunteer = new frmAddEditAdminstrator(selectedAdmin);
                frmAddEditVolunteer.Show();
            }
        }

        private void dgvVolunteers_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedVolunteer = dgvVolunteers.SelectedRows[0].DataBoundItem as GetVolunteerDetailsResposne;
            if (selectedVolunteer != null)
            {
                frmAddEditVolunteer frmAddEditVolunteer = new frmAddEditVolunteer(selectedVolunteer);
                frmAddEditVolunteer.Show();
            }
        }

        private async void dgvVolunteers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var selectedVolunteer = dgvVolunteers.SelectedRows[0].DataBoundItem as GetVolunteerDetailsResposne;
            if (selectedVolunteer != null)
            {
                if (e.ColumnIndex == 5)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmAllVolunteers_Load(sender, e);
                    }
                    else
                    {
                        await _apiServiceVolunters.Delete<ResponseResult>(selectedVolunteer.Id);
                        frmAllVolunteers_Load(sender, e);
                    }
                }
            }
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            frmAddEditAdminstrator frmAddEditAdminstrator = new frmAddEditAdminstrator();
            frmAddEditAdminstrator.Show();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var query = txtSearch.Text;
            var result = await _apiServiceFilteredAdmin.GetSearch<List<Administrator>>(query);
           
            dgvAdmins.DataSource = result;
        }

        private async void volunteersSearch_TextChanged(object sender, EventArgs e)
        {
            var query = volunteersSearch.Text;
            var result = await _apiServiceFilteredVolunteer.GetSearch<List<Volunteer>>(query);
           
             dgvVolunteers.DataSource = result;
        }
    }
}
