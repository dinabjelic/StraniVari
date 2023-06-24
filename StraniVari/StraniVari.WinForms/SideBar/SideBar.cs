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

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            Helpers.JWTDecoder.ShowEmail(lblName);
        }
    }
}
