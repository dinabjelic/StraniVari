using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.Service;

namespace StraniVari.WinUI.PlanAndProgramme
{
    public partial class frmAllPlanAndProgramme : Form
    {
        ApiService _apiService = new ApiService("PlanAndProgramme/planAndProgramme");
        public EventUpsertRequest SelectedEvent { get; }
        public frmAllPlanAndProgramme(EventUpsertRequest selectedEvent)
        {
            InitializeComponent();
            SelectedEvent = selectedEvent;
        }

        public async void frmAllPlanAndProgramme_Load(object sender, EventArgs e)
        {
            dgvPlanAndProgramme.AutoGenerateColumns = false;
            var result = await _apiService.GetById<List<GetPlanAndProgrameResposnse>>(SelectedEvent.Id);
            dgvPlanAndProgramme.DataSource = result;
            txtName.Text = SelectedEvent.Name;
            txtTheme.Text = SelectedEvent.StraniVariTheme;
            txtStartDate.Text = SelectedEvent.StartDate.ToString("D");
            txtEndDate.Text = SelectedEvent.EndDate.ToString("D");
        }

        private void dgvPlanAndProgramme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedPlan = dgvPlanAndProgramme.SelectedRows[0].DataBoundItem as GetPlanAndProgrameResposnse;

            if (selectedPlan != null)
            {
                if (e.ColumnIndex == 3)
                {
                    frmActivities frmActivities = new frmActivities(selectedPlan, SelectedEvent);
                    frmActivities.ShowDialog();
                }
                else if (e.ColumnIndex == 4)
                {
                    frmAddEditProgramme frmAddEditProgramme = new frmAddEditProgramme(SelectedEvent, selectedPlan);
                    frmAddEditProgramme.ShowDialog();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProgramme frmAddEditProgramme = new frmAddEditProgramme(SelectedEvent);
            frmAddEditProgramme.ShowDialog();
        }
    }
}
