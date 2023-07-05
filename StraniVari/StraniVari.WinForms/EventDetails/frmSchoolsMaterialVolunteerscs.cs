using StraniVari.Core.Entities;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Reports;
using StraniVari.WinUI.SchoolDetails;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.EventDetails
{
    public partial class frmSchoolsMaterialVolunteerscs : Form
    {

        ApiService _apiService = new ApiService("EventSchool/getActiveSchools");
        ApiService _apiServiceMaterial = new ApiService("Materials");
        ApiService _apiServiceVolunteers = new ApiService("SchoolVolunteers/getEventVolunteers");
        ApiService _apiServiceEventSchool = new ApiService("EventSchool");

        private EventUpsertRequest selectedEvent;

        public frmSchoolsMaterialVolunteerscs(EventUpsertRequest selectedEvent)
        {
            InitializeComponent();
            this.selectedEvent = selectedEvent;
        }

        private async void frmSchoolsMaterialVolunteerscs_Load(object sender, EventArgs e)
        {
            await LoadSchoolComboBoxValues();
            await LoadMaterials();
            await LoadVolunteers();
            dgvMaterialForSchool.CellValidating += dgvMaterialForSchool_CellValidating;
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Text = "-";
        }

        private async Task LoadSchoolComboBoxValues()
        {
            var result = await _apiService.GetById<List<GetAvailableSchoolsForEventResponse>>(selectedEvent.Id);
            comboBox1.DataSource = result;
            comboBox1.DisplayMember = "SchoolName";
            comboBox1.ValueMember = "SchoolId";
        }

        private async Task LoadMaterials()
        {
            dgvMaterialForSchool.AutoGenerateColumns = false;
            var result = await _apiServiceMaterial.Get<List<GetMaterialResponse>>();
            dgvMaterialForSchool.DataSource = result;
        }

        private async Task LoadVolunteers()
        {
            dgvVolunteers.AutoGenerateColumns = false;
            var result = await _apiServiceVolunteers.GetById<List<GetVolunteersForEventResponse>>(selectedEvent.Id);
            dgvVolunteers.DataSource = result;
        }

        private async void button1_Click(object sender, EventArgs e)
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

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("All schools have been added to the event.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                var schoolVolunteerMaterialRequest = new SchoolVolunteerMaterialRequest
                {
                    NumberOfChildren = Int32.TryParse(txtNumberOfChildren.Text, out var result) ? result : 0,
                    EventId = selectedEvent.Id,
                    SchoolId = (int)comboBox1.SelectedValue,
                    Material = checkedMaterialItems,
                    Volunteers = checkedVolunteerItems
                };
                await _apiServiceEventSchool.Insert<ResponseResult>(schoolVolunteerMaterialRequest);
                MessageBox.Show("School, volunteers and materials successfully added.", "Infomation", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
                Close();
                var principalForm = Application.OpenForms.OfType<frmEventTabs>().FirstOrDefault();
                principalForm.frmSchoolsEventDetails_Load(sender, e);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvMaterialForSchool_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3) // Replace `yourNumericColumnIndex` with the actual index of your numeric column
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int numericValue))
                {
                    // If the user enters a non-numeric value, convert it to zero
                    dgvMaterialForSchool.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
        }

        private void dgvMaterialForSchool_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvVolunteers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNumberOfChildren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
