using Newtonsoft.Json;
using StraniVari.Core.Entities;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Games
{
    public partial class frmGames : Form
    {
        ApiService _apiService = new ApiService("Games/games");
        ApiService _apiServiceDelete = new ApiService("Games");
        private readonly ApiService _apiServiceFiltered = new ApiService("Games/filtered-data");

        public frmGames()
        {
            InitializeComponent();
        }

        public async void frmGames_Load(object sender, EventArgs e)
        {
            dgvGames.AutoGenerateColumns = false;
            var result = await _apiService.Get<List<GetGamesResponse>>();
            dgvGames.DataSource = result;
        }

        private async void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRecord = dgvGames.SelectedRows[0].DataBoundItem as GetGamesResponse;
            if (e.ColumnIndex == 2 && selectedRecord != null)
            {
                frmGameDetails frmGameDetails = new frmGameDetails(selectedRecord);
                frmGameDetails.Show();
            }
            else if (e.ColumnIndex == 3)
            {
                var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmation == DialogResult.No)
                {
                    frmGames_Load(sender, e);
                }
                else
                {
                    await _apiServiceDelete.Delete<ResponseResult>(selectedRecord.Id);
                    frmGames_Load(sender, e);
                }
            }
        }

        private void dgvGames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedRecord = dgvGames.SelectedRows[0].DataBoundItem as GetGamesResponse;
            if (selectedRecord != null)
            {
                frmAddEditGame frmGameDetails = new frmAddEditGame(null, null, selectedRecord);
                frmGameDetails.Show();
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            frmAddEditGame frmAddEditGame = new frmAddEditGame();
            frmAddEditGame.Show();
        }

        private async void gameSearch_TextChanged(object sender, EventArgs e)
        {
            var query = gameSearch.Text;
            var result = await _apiServiceFiltered.GetSearch<List<GetGamesResponse>>(query);

            dgvGames.DataSource = result;
        }
    }
}
