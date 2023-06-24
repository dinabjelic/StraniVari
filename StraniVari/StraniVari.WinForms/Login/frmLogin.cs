using StraniVari.Common.Constants;
using StraniVari.Core.Helper;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.EventDetails;
using StraniVari.WinUI.Service;
using StraniVari.WinUI.StartPage;

namespace StraniVari.WinUI.Login
{
    public partial class frmLogin : Form
    {
        private readonly ApiService _apiService = new ApiService("Autentication/Login");
        int clickCounter = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            if (ValidateEntry())
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
                    btnLogin.Enabled = true;
                    return;
                }
                try
                {
                    var result = await _apiService.Login<GetUserResponse>(requestLoginDto);

                  
                    if (result.Roles.All(x => x == Role.RegularUser))
                    {
                        throw new Exception();
                    }
                    ApiService.Token = result.Token;
                    frmStartPage frm = new frmStartPage();
                    //frmAllEvents frm = new frmAllEvents();

                    frm.ShowDialog();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid username or password");
                    btnLogin.Enabled = true;
                }
            }
        }

        private bool ValidateEntry()
        {
            return ValidateControl(txtUsername, Constants.RequiredValue) &&
                   ValidateControl(txtPassword, Constants.RequiredValue);
        }

        private bool ValidateControl(Control control, string message)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                err.SetError(control, message);
                btnLogin.Enabled = true;
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
