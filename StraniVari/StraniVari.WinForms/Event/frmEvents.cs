using StraniVari.WinUI.Service;
using System;
using System.Windows.Forms;

namespace StraniVari.WinUI.Event
{
    public partial class frmEvents : Form
    {
        private readonly ApiService _apiService = new ApiService("Event"); 
        public frmEvents()
        {
            InitializeComponent();
        }

        private async void btnShowEvents_Click(object sender, EventArgs e)
        {
            var result = await _apiService.Get<dynamic>();
            dgvEvents.DataSource = result;
        }
    }
}
