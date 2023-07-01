using StraniVari.Common.Constants;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Games
{
    public partial class frmAddEditGame : Form
    {
        ApiService _apiService = new ApiService("Games");
        public string GameName { get; }
        public string Rule { get; }
        public GetGamesResponse SelectedItem { get; }
        public frmAddEditGame(string gameName = null, string rule = null, GetGamesResponse selectedItem = null)
        {
            InitializeComponent();
            GameName = gameName;
            Rule = rule;
            SelectedItem = selectedItem;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                var game = new UpSertGameRequest
                {
                    Name = txtGameName.Text,
                    Rules = rtbRules.Text
                };

                if (SelectedItem == null)
                {
                    await _apiService.Insert<ResponseResult>(game);
                    MessageBox.Show("Game successfully added.", "Infomation", MessageBoxButtons.OK);
                }
                else
                {
                    var model = new GetGamesResponse
                    {
                        Name = txtGameName.Text,
                        Rules = rtbRules.Text
                    };
                    await _apiService.Update<ResponseResult>(model, SelectedItem.Id);
                    MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }

            var principalForm = Application.OpenForms.OfType<frmGames>().FirstOrDefault();
            principalForm.frmGames_Load(sender, e);
        }

        private void frmAddEditGame_Load(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                txtGameName.Text = SelectedItem.Name;
                rtbRules.Text = SelectedItem.Rules;
            }
        }

        private bool ValidateEntry()
        {
            return ValidateControl(txtGameName, Constants.RequiredValue) &&
                   ValidateControl(rtbRules, Constants.RequiredValue);
        }

        private bool ValidateControl(Control control, string message)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                err.SetError(control, message);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
