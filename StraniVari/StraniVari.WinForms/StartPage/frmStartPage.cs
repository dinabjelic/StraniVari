using StraniVari.WinUI.Admin;
using StraniVari.WinUI.EventDetails;
using StraniVari.WinUI.Games;
using StraniVari.WinUI.Login;
using StraniVari.WinUI.Material;
using StraniVari.WinUI.Reports;
using StraniVari.WinUI.SchoolDetails;
using StraniVari.WinUI.Service;
using StraniVari.WinUI.Trip;
using System.IdentityModel.Tokens.Jwt;

namespace StraniVari.WinUI.StartPage
{
    public partial class frmStartPage : Form
    {
        public frmStartPage()
        {
            InitializeComponent();
        }

        private void frmStartPage_Load(object sender, EventArgs e)
        {
            var stream = ApiService.Token;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(stream);

            string firstName = jsonToken.Claims.First(claim => claim.Type == "given_name").Value;
            if (!string.IsNullOrEmpty(firstName))
            {
                firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1);
            }

            lblName.Text = firstName;
        }

        private void btnTrips_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmTripTabs frmTripTabs = new frmTripTabs();
            frmTripTabs.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAllMaterial frmAllMaterial = new frmAllMaterial();
            frmAllMaterial.Show();
        }

        private void btnSchool_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAllSchools frmAllSchools = new frmAllSchools();
            frmAllSchools.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGames frmGames = new frmGames();
            frmGames.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsersTab frmUsersTab = new frmUsersTab();
            frmUsersTab.Show();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAllEvents frmAllEvents = new frmAllEvents();
            frmAllEvents.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReport frmGamesSchoolsReportscs = new frmReport();
            frmGamesSchoolsReportscs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApiService.Token = null;
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
