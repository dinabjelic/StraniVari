using StraniVari.Core.Entities;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Games
{
    public partial class frmAllGames : Form
    {
        ApiService _apiService = new ApiService("Games/with-details");
        ApiService _apiServiceDelete = new ApiService("Games");
        public frmAllGames()
        {
            InitializeComponent();
        }

        public async void frmAllGames_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<GetGamesResponse>>();
            listBox1.SelectedItems.Remove(result);
            listBox1.ScrollAlwaysVisible = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.DataSource = result;
            foreach (var item in result)
            {
                listBox1.ValueMember = "Id";
                listBox1.DisplayMember = "Name";
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            frmAddEditGame frmAddEditGame = new frmAddEditGame();
            frmAddEditGame.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem as GetGamesResponse;
            var nameUncompleted = selectedItem.Name.Split(',')[0];
            var name = nameUncompleted.Substring(nameUncompleted.IndexOf("Name: ") + "Name: ".Length);
            var rule = selectedItem.Name.Substring(selectedItem.Name.IndexOf(",Rules: ") + ",Rules: ".Length);

            if (selectedItem != null)
            {
                frmAddEditGame frmAddEditGame = new frmAddEditGame(name, rule, selectedItem);
                frmAddEditGame.ShowDialog();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem as GetGamesResponse;

            var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.No)
            {
                frmAllGames_Load(sender, e);
            }
            else
            {
                await _apiServiceDelete.Delete<ResponseResult>(selectedItem.Id);
                frmAllGames_Load(sender, e);
            }
        }
    }
}
