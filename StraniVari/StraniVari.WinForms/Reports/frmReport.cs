using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Reports
{
    public partial class frmReport : Form
    {
        private readonly ApiService _apiService = new ApiService("Event");
        private readonly ApiService _apiServiceEventSchools = new ApiService("EventSchool/get");

        public GetEventDetailsResponse _selectedEvent { get; set; }
        public GetSchoolsForEventResponse _selectedSchool { get; set; }

        public frmReport()
        {
            InitializeComponent();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadSchoolComboBoxValues();
        }

        private async void frmReport_Load(object sender, EventArgs e)
        {
            await LoadComboBoxValues();
        }
        private async Task LoadSchoolComboBoxValues()
        {
            _selectedEvent = (GetEventDetailsResponse)comboBox1.SelectedItem;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            var result = await _apiServiceEventSchools.GetById<List<GetSchoolsForEventResponse>>(_selectedEvent.Id);
            comboBox2.DataSource = result;
            //comboBox2.DisplayMember = "-";
            result.Insert(0, new GetSchoolsForEventResponse { SchoolId = 0, SchoolName = "-" });
            comboBox2.DisplayMember = "SchoolName";
            comboBox2.ValueMember = "SchoolId";
            comboBox2.SelectedIndexChanged -= comboBox2_SelectedIndexChanged;
            _selectedSchool = (GetSchoolsForEventResponse)comboBox2.SelectedItem;
            //if(_selectedSchool.SchoolName != "-")
            //{
            //    btnGenerateReport.Enabled = true;
            //} 
        }

        private async Task LoadComboBoxValues()
        {
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            var result = await _apiService.Get<List<GetEventDetailsResponse>>();
            comboBox1.DataSource = result;
            result.Insert(0, new GetEventDetailsResponse { Id = 0, Name = "-" });
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_selectedEvent != null && _selectedSchool != null)
            {
                frmReports frmReports = new frmReports(_selectedEvent, _selectedSchool);
                frmReports.ShowDialog();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { }
    }
}


//na on change da se ocisti vrijednost u drugom combo boxu