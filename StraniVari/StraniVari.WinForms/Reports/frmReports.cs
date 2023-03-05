using Microsoft.Reporting.WinForms;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Reports
{
    public partial class frmReports : Form
    {
        private readonly ApiService _apiServiceVolunteers = new ApiService("SchoolVolunteers");
        private readonly ApiService _apiServiceMaterial = new ApiService("SchoolMaterials");
        public frmReports(EventUpsertRequest selectedEvent, GetSchoolsForEventResponse selectedSchool)
        {
            InitializeComponent();
            SelectedEvent = selectedEvent;
            SelectedSchool = selectedSchool;
        }

        public EventUpsertRequest SelectedEvent { get; }
        public GetSchoolsForEventResponse SelectedSchool { get; }

        private async void frmReports_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "StraniVari.WinUI.Reports.Report1.rdlc";


            var volunteersForSchool = await _apiServiceVolunteers.GetById<List<GetVolunteersForSchoolResponse>>(SelectedSchool.SchoolEventId);
            var materialForSchool = await _apiServiceMaterial.GetById<List<GetMaterialsForSchoolRequest>>(SelectedSchool.SchoolEventId);
            var parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("EventName", SelectedEvent.Name));
            parameters.Add(new ReportParameter("StraniVariTheme", SelectedEvent.StraniVariTheme));
            parameters.Add(new ReportParameter("StartDate", SelectedEvent.StartDate.ToString("D")));
            parameters.Add(new ReportParameter("EndDate", SelectedEvent.EndDate.ToString("D")));
            parameters.Add(new ReportParameter("SchoolName", SelectedSchool.SchoolName));
            parameters.Add(new ReportParameter("SchoolAddress", SelectedSchool.SchoolAddress));
            parameters.Add(new ReportParameter("SchoolCity", SelectedSchool.SchoolCity));

            dsEventDetails.VolunteersDataTable volunteerTable = new dsEventDetails.VolunteersDataTable();
            dsEventDetails.MaterialDataTable materialTable = new dsEventDetails.MaterialDataTable();

            foreach (var item in volunteersForSchool)
            {
                var row = volunteerTable.NewVolunteersRow();
                row.FirstName = item.FirstName;
                row.LastName = item.LastName;
                row.Address = item.VolunteerAddress;
                row.City = item.VolunteerCity;
                row.DateOfBirth = item.VolunteerBirthDate.ToString("D");
                row.Id = item.VolunteerId;
                row.TransportNeeded = (bool)item.TransportNeeded ? "Yes" : "No";
                volunteerTable.AddVolunteersRow(row);
            }


            foreach (var item in materialForSchool)
            {
                var row = materialTable.NewMaterialRow();
                row.MaterialName = item.MaterialName;
                row.Quantity = item.Quantity;
                materialTable.AddMaterialRow(row);
            }

            ReportDataSource reportDataSourceVolunteers = new ReportDataSource();
            reportDataSourceVolunteers.Name = "dsVolunteers";
            reportDataSourceVolunteers.Value = volunteerTable;

            ReportDataSource reportDataSourceMaterial = new ReportDataSource();
            reportDataSourceMaterial.Name = "dsMaterial";
            reportDataSourceMaterial.Value = materialTable;

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSourceVolunteers);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSourceMaterial);
            this.reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.RefreshReport();
        }
    }
}
