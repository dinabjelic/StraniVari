using StraniVari.WinUI.Admin;
using StraniVari.WinUI.Games;
using StraniVari.WinUI.SchoolDetails;
using StraniVari.WinUI.Trip;

namespace StraniVari.WinUI.Material
{
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            frmTripTabs frmAllTrips = new frmTripTabs();
            frmAllTrips.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmAllMaterial frmAllMaterial = new frmAllMaterial();
            frmAllMaterial.Show();
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            Helpers.JWTDecoder.ShowEmail(lblName);
        }

        private void btnSchool_Click(object sender, EventArgs e)
        {
            frmAllSchools frmAllSchools = new frmAllSchools();
            frmAllSchools.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            frmGames frmGames = new frmGames();
            frmGames.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUsersTab frmUsersTab = new frmUsersTab();
            frmUsersTab.Show();
        }
    }
}
