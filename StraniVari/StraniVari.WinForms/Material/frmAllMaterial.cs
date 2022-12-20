using Newtonsoft.Json;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Material
{
    public partial class frmAllMaterial : Form
    {
        ApiService _apiService = new ApiService("Materials");
        public frmAllMaterial()
        {
            InitializeComponent();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            frmAddEditMaterial frmAddEditMaterial = new frmAddEditMaterial();
            frmAddEditMaterial.Show();
        }

        public async void frmAllMaterial_Load(object sender, EventArgs e)
        {
            dgvMaterial.AutoGenerateColumns = false;
            var result = await _apiService.Get<dynamic>();
            dgvMaterial.DataSource = result;
        }

        private async void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedMaterial =JsonConvert.DeserializeObject<GetMaterialDetailsResponse>(dgvMaterial.SelectedRows[0].DataBoundItem.ToString());
            if(selectedMaterial != null)
            {
                if (e.ColumnIndex == 2)
                {
                    frmAddEditMaterial frmAddEditMaterial = new frmAddEditMaterial(selectedMaterial);
                    frmAddEditMaterial.Show();
                }
                else if(e.ColumnIndex ==3)
                {
                    MessageBox.Show("You are about to delete this item!");
                    await _apiService.Delete<ResponseResult>(selectedMaterial.Id);
                    frmAllMaterial_Load(sender, e);
                }
            }
        }
    }
}
