using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Event;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Login
{
    public partial class frmLogin : Form
    {
        private readonly ApiService _apiService = new ApiService("Autentication/Login");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            RequestLoginDto requestLoginDto = new RequestLoginDto
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            if (requestLoginDto == null)
            {
                MessageBox.Show("Wrong username or password", "Information", MessageBoxButtons.OK);
                txtUsername.Text = txtPassword.Text = "";
                return;
            }

            try
            {
                var result = await _apiService.Login<GetUserResponse>(requestLoginDto);
                ApiService.Token = result.Token;
                frmEvents frm = new frmEvents();
                frm.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
