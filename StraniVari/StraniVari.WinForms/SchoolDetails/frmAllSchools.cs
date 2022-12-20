﻿using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.SchoolDetails
{
    public partial class frmAllSchools : Form
    {
        private readonly ApiService _apiService = new ApiService("Schools");
        public frmAllSchools()
        {
            InitializeComponent();
        }

        public async void frmAllSchools_Load(object sender, EventArgs e)
        {
            dgvSchools.AutoGenerateColumns = false;
            var result =await _apiService.Get<List<GetSchoolDetailsResponse>>();
            dgvSchools.DataSource = result;
        }

        private async void dgvSchools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedSchool = dgvSchools.SelectedRows[0].DataBoundItem as GetSchoolDetailsResponse;
            if(selectedSchool != null)
            {
                if(e.ColumnIndex == 4)
                {
                    frmAddEditSchool frmAddEditSchool = new frmAddEditSchool(selectedSchool);
                    frmAddEditSchool.Show();
                }
                else if(e.ColumnIndex == 5)
                {
                    MessageBox.Show("You are about to delete this item!");
                    await _apiService.Delete<ResponseResult>(selectedSchool.Id);
                    frmAllSchools_Load(sender, e);
                }
            }
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            frmAddEditSchool frmAddEditSchool = new frmAddEditSchool();
            frmAddEditSchool.Show();
        }
    }
}
