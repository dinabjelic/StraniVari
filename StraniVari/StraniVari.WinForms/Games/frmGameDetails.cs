using StraniVari.Core.Responses;

namespace StraniVari.WinUI.Games
{
    public partial class frmGameDetails : Form
    {
        private GetGamesResponse? selectedRecord;

        public frmGameDetails(GetGamesResponse? selectedRecord)
        {
            this.selectedRecord = selectedRecord;
            InitializeComponent();
        }

        private void frmGameDetails_Load(object sender, EventArgs e)
        {
            this.txtGameName.Text = selectedRecord.Name;
            this.rtbRules.Text = selectedRecord.Rules;
        }
    }
}
