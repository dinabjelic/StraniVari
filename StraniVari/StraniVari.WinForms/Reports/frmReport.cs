namespace StraniVari.WinUI.Reports
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnEventDetails_Click(object sender, EventArgs e)
        {
            frmEventDetailsReport frmReport = new frmEventDetailsReport();
            frmReport.ShowDialog();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            frmGamesReport frmGamesReport = new frmGamesReport();
            frmGamesReport.ShowDialog();
        }
    }
}
