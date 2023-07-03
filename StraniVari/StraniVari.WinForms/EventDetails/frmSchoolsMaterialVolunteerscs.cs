using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.EventDetails
{
    public partial class frmSchoolsMaterialVolunteerscs : Form
    {

        ApiService _apiService = new ApiService("EventSchool/getActiveSchools");
        ApiService _apiServiceMaterial = new ApiService("Materials");
        private EventUpsertRequest selectedEvent;

        public frmSchoolsMaterialVolunteerscs(EventUpsertRequest selectedEvent)
        {
            InitializeComponent();
            this.selectedEvent = selectedEvent;
        }

        private async void frmSchoolsMaterialVolunteerscs_Load(object sender, EventArgs e)
        {
            await LoadSchoolComboBoxValues();
            await LoadMaterialForSchoolValues();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "-";
        }

        private async Task LoadSchoolComboBoxValues()
        {
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            var result = await _apiService.GetById<List<GetAvailableSchoolsForEventResponse>>(selectedEvent.Id);
            comboBox1.DataSource = result;
            comboBox1.DisplayMember = "SchoolName";
            comboBox1.ValueMember = "SchoolId";
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            var valu = comboBox1.SelectedValue;
        }

        private async Task LoadMaterialForSchoolValues()
        {
            dgvMaterialForSchool.AutoGenerateColumns = false;
            var result = await _apiServiceMaterial.Get<List<GetMaterialResponse>>();
            dgvMaterialForSchool.DataSource = result;
        }
    }
}
