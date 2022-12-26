﻿using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.Material
{
    public partial class frmAddMaterialToSchool : Form
    {
        ApiService _apiService = new ApiService("Materials");
        private readonly ApiService _apiServiceMaterial = new ApiService("SchoolMaterials");
        public GetSchoolsForEventResponse SelectedElement { get; }
        public EventUpsertRequest SelectedEvent { get; }

        public frmAddMaterialToSchool(GetSchoolsForEventResponse selectedElement, EventUpsertRequest selectedEvent)
        {
            InitializeComponent();
            SelectedElement = selectedElement;
            SelectedEvent = selectedEvent;
        }

        private async void frmAddMaterialToSchool_Load(object sender, EventArgs e)
        {
            await LoadEventDetails();
            await LoadTextBoxValues();
        }

        private async Task LoadTextBoxValues()
        {
            var material = await _apiService.Get<List<GetMaterialDetailsResponse>>();
            lbxMaterial.DataSource = material;
            lbxMaterial.ValueMember = "Id";
            lbxMaterial.DisplayMember = "Name";
        }

        private async Task LoadEventDetails()
        {
            txtName.Text = SelectedEvent.Name;
            txtTheme.Text = SelectedEvent.StraniVariTheme;
            txtStartDate.Text = SelectedEvent.StartDate.ToString("D");
            txtEndDate.Text = SelectedEvent.EndDate.ToString("D");
            txtSchool.Text = SelectedElement.SchoolName;
        }

        private async void btnAddMaterialToSchool_Click(object sender, EventArgs e)
        {
            var materialForSchool =await _apiServiceMaterial.GetById<List<GetMaterialsForSchoolRequest>>(SelectedElement.SchoolEventId);
            var materials = new InsertMaterialToSchoolRequest
            {
                EventSchoolId = SelectedElement.SchoolEventId,
                Materials = lbxMaterial.SelectedItems.Cast<GetMaterialDetailsResponse>()
                .Select(x => x.Id)
                .ToArray()
            };

            bool added = false;
            foreach(var item in materialForSchool)
            {
                foreach(var i in materials.Materials)
                {
                    if(item.MaterialId == i)
                    {
                        added = true;
                        break;
                    }
                }
            }

            if (!added)
            {
                await _apiServiceMaterial.Insert<ResponseResult>(materials);
                MessageBox.Show("Material successfully added.", "Infomation", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You cannot add duplicate material to the same school.", "Infomation", MessageBoxButtons.OK);
                Close();
            }

            frmMaterialDetails frmMaterialDetails = new frmMaterialDetails(SelectedEvent, SelectedElement);
            frmMaterialDetails.ShowDialog();
        }

        private void lbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = lbxMaterial.SelectedItems.Count.ToString();
        }
    }
}