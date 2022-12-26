﻿using StraniVari.Core.Entities;
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
        public frmAddEditGame(string gameName = null, string rule = null, GetGamesResponse selectedItem=null)
        {
            InitializeComponent();
            GameName = gameName;
            Rule = rule;
            SelectedItem = selectedItem;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var game = new UpSertGameRequest
            {
                Name = txtGameName.Text,
                Rules = rtbRules.Text
            };

            if (GameName == null)
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

            var principalForm = Application.OpenForms.OfType<frmAllGames>().FirstOrDefault();
            principalForm.frmAllGames_Load(sender, e);
        }

        private void frmAddEditGame_Load(object sender, EventArgs e)
        {
            if (GameName != null)
            {
                txtGameName.Text = GameName;
                rtbRules.Text = Rule.Substring(Rule.IndexOf("Rules: ") + "Rules: ".Length);
            }
        }
    }
}
