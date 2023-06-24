using StraniVari.WinUI.Games;
using StraniVari.WinUI.Material;
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
            frmTripTabs frmTripTabs = new frmTripTabs();
            frmTripTabs.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmAllMaterial frmAllMaterial = new frmAllMaterial();
            frmAllMaterial.Show();
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
    }
}
