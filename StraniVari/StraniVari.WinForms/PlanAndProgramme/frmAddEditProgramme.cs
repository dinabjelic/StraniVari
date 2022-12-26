using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.PlanAndProgramme
{
    public partial class frmAddEditProgramme : Form
    {
        private readonly ApiService _apiService = new ApiService("PlanAndProgramme");
        public GetPlanAndProgrameResposnse SelectedPlan { get; }
        public EventUpsertRequest SelectedEvent { get; }
        public frmAddEditProgramme(EventUpsertRequest selectedEvent = null,GetPlanAndProgrameResposnse selectedPlan=null)
        {
            InitializeComponent();
            SelectedPlan = selectedPlan;
            SelectedEvent = selectedEvent;
        }

        private void frmAddEditProgramme_Load(object sender, EventArgs e)
        {
            txtName.Text = SelectedEvent.Name;
            txtTheme.Text = SelectedEvent.StraniVariTheme;
            txtStartDate.Text = SelectedEvent.StartDate.ToString("D");
            txtEndDate.Text = SelectedEvent.EndDate.ToString("D");


            if (SelectedPlan != null)
            {
                dtpEndDatePP.Value = SelectedPlan.EndDate;
                dtpStartDatePP.Value = SelectedPlan.StartDate;
                rtbRules.Text = SelectedPlan.Activity;
            }    
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var planAndProgramme = new UpSertPlanAndProgrammeRequest
            {
                Activity = rtbRules.Text,
                EventId = SelectedEvent.Id,
                EndDate = dtpStartDatePP.Value,
                StartDate = dtpStartDatePP.Value
            };

            if (SelectedPlan == null)
            {
                await _apiService.Insert<ResponseResult>(planAndProgramme);
                MessageBox.Show("Plan and programme successfully added.", "Infomation", MessageBoxButtons.OK);
            }
            else
            {
                await _apiService.Update<ResponseResult>(planAndProgramme, SelectedPlan.Id);
                MessageBox.Show("Details successfully updated.", "Infomation", MessageBoxButtons.OK);
            }
            this.DialogResult = DialogResult.OK;
            Close();

            var principalForm = Application.OpenForms.OfType<frmAllPlanAndProgramme>().FirstOrDefault();
            principalForm.frmAllPlanAndProgramme_Load(sender, e);
        }
    }
}
