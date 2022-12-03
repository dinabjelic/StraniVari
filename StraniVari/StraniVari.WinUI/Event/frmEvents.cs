using Flurl.Http;
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

        private void btnShowEvents_Click(object sender, EventArgs e)
        {
            //var result = "https://localhost:7241/api/Event".GetJsonAsync<dynamic>().Result;

            var result = _apiService.GetRoute<dynamic>();
            dgvEvents.DataSource =result;
        }
    }
}
