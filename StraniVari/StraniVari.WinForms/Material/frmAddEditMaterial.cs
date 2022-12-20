using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Material
{
    public partial class frmAddEditMaterial : Form
    {
        ApiService _apiService = new ApiService("Materials");
        public frmAddEditMaterial(GetMaterialDetailsResponse selectedMaterial=null)
        {
            InitializeComponent();
            SelectedMaterial = selectedMaterial;
        }

        public GetMaterialDetailsResponse? SelectedMaterial { get; }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var newMaterial = new MaterialUpsertRequest
            {
                Name = txtMaterialName.Text
            };

            if(SelectedMaterial == null)
            {
                await _apiService.Insert<ResponseResult>(newMaterial);
                MessageBox.Show("Material successfully added.", "Infomation", MessageBoxButtons.OK);
            }
            else
            {
                await _apiService.Update<ResponseResult>(newMaterial, SelectedMaterial.Id);
                MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
            }
            this.DialogResult = DialogResult.OK;
            Close();

            var principalForm = Application.OpenForms.OfType<frmAllMaterial>().FirstOrDefault();
            principalForm.frmAllMaterial_Load(sender, e);
        }

        private void frmAddEditMaterial_Load(object sender, EventArgs e)
        {
            if (SelectedMaterial != null)
            {
                txtMaterialName.Text = SelectedMaterial.Name;
            }
        }
    }
}
