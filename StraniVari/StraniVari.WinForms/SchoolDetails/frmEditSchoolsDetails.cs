using StraniVari.Common.Constants;
using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.EventDetails;
using StraniVari.WinUI.RecommendationSystem;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmEditSchoolsDetails : Form
    {
        ApiService _apiServiceEventSchool = new ApiService("EventSchool");
        ApiService _apiServiceEventSchoolDetails = new ApiService("EventSchool/get");
        ApiService _apiServiceSchoolMaterial = new ApiService("SchoolMaterials/getEventSchoolsMaterial");
        ApiService _apiServiceSchoolVolunteers = new ApiService("SchoolVolunteers/getEventSchoolsVolunteers");
        ApiService _apiServiceMaterialGet = new ApiService("SchoolMaterials/get");
        ApiService _apiServiceMaterial = new ApiService("SchoolMaterials");


        public GetSchoolsForEventResponse _selectedSchool { get; }
        public EventUpsertRequest _selectedEvent { get; }

        public frmEditSchoolsDetails(GetSchoolsForEventResponse selectedSchool = null, EventUpsertRequest selectedEvent = null)
        {
            InitializeComponent();
            _selectedEvent = selectedEvent;
            _selectedSchool = selectedSchool;
        }

        public frmEditSchoolsDetails(EventUpsertRequest selectedEvent, GetSchoolsForEventResponse selectedSchool)
        {
            InitializeComponent();
            _selectedEvent = selectedEvent;
            _selectedSchool = selectedSchool;
        }

        private void frmEditSchoolsDetails_Load(object sender, EventArgs e)
        {
            txtNumberOfChildren.Text = _selectedSchool.NumberOfChildren.ToString();
            txtSchoolAddress.Text = _selectedSchool.SchoolAddress;
            txtSchoolCity.Text = _selectedSchool.SchoolCity;
            txtSchoolName.Text = _selectedSchool.SchoolName;
            frmMaterialDetails_Load(sender, e);
            frmVolunteersDetails_Load(sender, e);
        }

        public async void frmMaterialDetails_Load(object sender, EventArgs e)
        {
            dgvMaterialForSchool.AutoGenerateColumns = false;
            var result = await _apiServiceSchoolMaterial.GetById<List<GetMaterialResponse>>(_selectedSchool.SchoolEventId);
            dgvMaterialForSchool.DataSource = result;
        }

        public async void frmVolunteersDetails_Load(object sender, EventArgs e)
        {
            dgvVolunteers.AutoGenerateColumns = false;
            var result = await _apiServiceSchoolVolunteers.GetById<List<GetVolunteersForEventResponse>>(_selectedSchool.SchoolEventId);
            dgvVolunteers.DataSource = result;
        }

        private async void btnEditSchoolDetails_Click(object sender, EventArgs e)
        {
            var checkedMaterialItems = new List<GetMaterialResponse>();
            foreach (DataGridViewRow row in dgvMaterialForSchool.Rows)
            {
                var checkBoxCell = row.Cells["IsChecked"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && checkBoxCell.Value is true)
                {
                    var item = row.DataBoundItem as GetMaterialResponse;
                    if (item != null)
                    {
                        checkedMaterialItems.Add(item);
                    }
                }
            }

            var checkedVolunteerItems = new List<GetVolunteersForEventResponse>();
            foreach (DataGridViewRow row in dgvVolunteers.Rows)
            {
                var checkBoxCell = row.Cells["Checked"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && checkBoxCell.Value is true)
                {
                    var item = row.DataBoundItem as GetVolunteersForEventResponse;
                    if (item != null)
                    {
                        checkedVolunteerItems.Add(item);
                    }
                }
            }


            var schoolVolunteerMaterialRequest = new SchoolVolunteerMaterialRequest
            {
                NumberOfChildren = Int32.TryParse(txtNumberOfChildren.Text, out var result) ? result : 0,
                EventId = _selectedEvent.Id,
                SchoolId = _selectedSchool.SchoolId,
                Material = checkedMaterialItems,
                Volunteers = checkedVolunteerItems
            };
            await _apiServiceEventSchool.Update<ResponseResult>(schoolVolunteerMaterialRequest, _selectedSchool.SchoolEventId);
            MessageBox.Show("School, volunteers and materials successfully updated.", "Infomation", MessageBoxButtons.OK);

            this.DialogResult = DialogResult.OK;
            Close();
            var principalForm = Application.OpenForms.OfType<frmEventTabs>().FirstOrDefault();
            principalForm.frmSchoolsEventDetails_Load(sender, e);
        }

        private bool ValidateEntry()
        {
            return ValidateControl(txtNumberOfChildren, Constants.RequiredValue);
        }

        private bool ValidateControl(Control control, string message)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                err.SetError(control, message);
                return false;
            }
            err.Clear();
            return true;
        }

        private void dgvVolunteers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvMaterialForSchool_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtNumberOfChildren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnRecMaterial_Click(object sender, EventArgs e)
        {
                var materialForSchool = await _apiServiceMaterialGet.GetById<List<GetMaterialsForSchoolRequest>>(_selectedSchool.SchoolEventId);

                var materialList = await _apiServiceMaterial.Get<List<SchoolMaterial>>($"{_selectedSchool.SchoolEventId}/recommend");

                if (materialList.Count() > 0)
                {
                    frmRecommendationSystem frmRecommendationSystem = new frmRecommendationSystem(materialList, _selectedSchool, materialForSchool);
                    frmRecommendationSystem.Show();
                }
                else
                {
                    MessageBox.Show("There are no recommended materials.");
                }
        }
    }
}
