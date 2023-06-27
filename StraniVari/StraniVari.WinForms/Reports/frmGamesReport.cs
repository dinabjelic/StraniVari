using Microsoft.Reporting.WinForms;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Reports
{
    public partial class frmGamesReport : Form
    {
        private readonly ApiService _apiServiceGames = new ApiService("Games/games");
        public frmGamesReport()
        {
            InitializeComponent();
        }

        private async void frmGamesReport_Load(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.ReportEmbeddedResource = "StraniVari.WinUI.Reports.Report2.rdlc";
            var games = await _apiServiceGames.Get<List<GetGamesResponse>>();

            dsGames.GamesDataTable gamesTable = new dsGames.GamesDataTable();
            foreach (var item in games)
            {
                var row = gamesTable.NewGamesRow();
                row.Name = item.Name;
                row.Rules = item.Rules;
                gamesTable.AddGamesRow(row);
            }

            ReportDataSource reportDataSourceGames = new ReportDataSource();
            reportDataSourceGames.Name = "dbGames";
            reportDataSourceGames.Value = gamesTable;

            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSourceGames);


            reportViewer2.RefreshReport();
        }
    }
}
