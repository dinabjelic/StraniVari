using StraniVari.Common.Constants;
using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.SchoolDetails;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Material
{
    public partial class frmEditMaterialDetails : Form
    {
        ApiService _apiServiceSchoolMaterials = new ApiService("SchoolMaterials");
        public GetMaterialsForSchoolRequest SelectedMaterial { get; }
        public EventUpsertRequest SelectedEvent { get; }
        public GetSchoolsForEventResponse SelectedElement { get; }
        public frmEditMaterialDetails(GetMaterialsForSchoolRequest selectedMaterial, EventUpsertRequest selectedEvent, GetSchoolsForEventResponse selectedElement)
        {
            InitializeComponent();
            SelectedMaterial = selectedMaterial;
            SelectedEvent = selectedEvent;
            SelectedElement = selectedElement;
        }

        public frmEditMaterialDetails(GetMaterialsForSchoolRequest selectedMaterial)
        {
            InitializeComponent();
            SelectedMaterial = selectedMaterial;
        }

        private void frmEditMaterialDetails_Load(object sender, EventArgs e)
        {
            txtQuantity.Text = SelectedMaterial.Quantity.ToString();
            txtMaterailName.Text = SelectedMaterial.MaterialName;
        }

        private async void btnEditSchoolDetails_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                var editedDetails = new UpdateMaterialToSchoolRequest
                {
                    SchoolMaterialId = SelectedMaterial.SchoolMaterialId,
                    Quantity = Int32.TryParse(txtQuantity.Text, out var result) ? result : 0
                };

                if (editedDetails != null)
                {
                    await _apiServiceSchoolMaterials.Update<ResponseResult>(editedDetails, editedDetails.SchoolMaterialId);
                    MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
                }
                this.DialogResult = DialogResult.OK;
                Close();

                var principalForm = Application.OpenForms.OfType<frmSchoolTabs>().FirstOrDefault();
                principalForm.frmMaterialDetails_Load(sender, e);
            }
        }

        private bool ValidateEntry()
        {
            return ValidateControl(txtQuantity, Constants.RequiredValue);
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
    }
}
