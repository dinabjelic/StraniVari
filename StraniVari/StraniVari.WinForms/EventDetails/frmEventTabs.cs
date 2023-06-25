using StraniVari.Core.Requests;
using StraniVari.Core.Responses;
using StraniVari.WinUI.PlanAndProgramme;
using StraniVari.WinUI.Service;
using System.Xml.Linq;

namespace StraniVari.WinUI.EventDetails
{
    public partial class frmEventTabs : Form
    {
        ApiService _apiService = new ApiService("PlanAndProgramme/planAndProgramme");
        ApiService _apiServiceDelete = new ApiService("PlanAndProgramme");
        private EventUpsertRequest selectedEvent;

        public frmEventTabs(EventUpsertRequest selectedEvent)
        {
            this.selectedEvent = selectedEvent;
            InitializeComponent();
        }

        private void frmEventTabs_Load(object sender, EventArgs e)
        {
            frmAllPlanAndProgramme_Load(sender, e);
        }

        public async void frmAllPlanAndProgramme_Load(object sender, EventArgs e)
        {
            dgvPlanAndProgramme.AutoGenerateColumns = false;
            var result = await _apiService.GetById<List<GetPlanAndProgrameResposnse>>(selectedEvent.Id);
            dgvPlanAndProgramme.DataSource = result;
        }

        private async void dgvPlanAndProgramme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedPlan = dgvPlanAndProgramme.SelectedRows[0].DataBoundItem as GetPlanAndProgrameResposnse;

            if (selectedPlan != null)
            {
                if (e.ColumnIndex == 3)
                {
                    //frmActivities frmActivities = new frmActivities(selectedPlan, SelectedEvent);
                    //frmActivities.ShowDialog();

                    frmActivities frmActivities = new frmActivities(selectedPlan, selectedEvent);
                    frmActivities.ShowDialog();
                }
                else if (e.ColumnIndex == 4)
                {
                    var confirmation = MessageBox.Show("You are about to delete this item!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.No)
                    {
                        frmAllPlanAndProgramme_Load(sender, e);
                    }
                    else
                    {
                        await _apiServiceDelete.Delete<ResponseResult>(selectedPlan.Id);
                        frmAllPlanAndProgramme_Load(sender, e);
                    }
                }
                //else if (e.ColumnIndex == 4)
                //{
                //    frmAddEditProgramme frmAddEditProgramme = new frmAddEditProgramme(selectedEvent, selectedPlan);
                //    frmAddEditProgramme.ShowDialog();
                //}
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProgramme frmAddEditProgramme = new frmAddEditProgramme(selectedEvent);
            frmAddEditProgramme.ShowDialog();
        }

        private void dgvPlanAndProgramme_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedPlan = dgvPlanAndProgramme.SelectedRows[0].DataBoundItem as GetPlanAndProgrameResposnse;

            if (selectedPlan != null)
            {
                frmAddEditProgramme frmAddEditProgramme = new frmAddEditProgramme(selectedEvent, selectedPlan);
                frmAddEditProgramme.ShowDialog();
            }
        }
    }
}
