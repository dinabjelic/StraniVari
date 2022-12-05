using StraniVari.WinUI.Event;
using StraniVari.WinUI.Service;
using System;
using System.Windows.Forms;

namespace StraniVari.WinUI.Login
{
    public partial class frmLogin : Form
    {
        private readonly ApiService _apiService = new ApiService("Event");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //RequestLoginDto requestLoginDto = new RequestLoginDto
            //{
                
            //}

            try
            {
                var result = await _apiService.GetRoute<dynamic>();

                frmEvents frm = new frmEvents();
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
