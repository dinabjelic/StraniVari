﻿using StraniVari.Core.Requests;
using StraniVari.Core.Responses;

namespace StraniVari.WinUI.PlanAndProgramme
{
    public partial class frmActivities : Form
    {
        public GetPlanAndProgrameResposnse SelectedPlan { get; }
        public EventUpsertRequest SelectedEvent { get; }
        public frmActivities(GetPlanAndProgrameResposnse selectedPlan, EventUpsertRequest selectedEvent)
        {
            InitializeComponent();
            SelectedPlan = selectedPlan;
            SelectedEvent = selectedEvent;
        }

        private void frmActivities_Load(object sender, EventArgs e)
        {
            rtbActivities.Text = SelectedPlan.Activity;
            txtStartDatePP.Text = SelectedPlan.StartDate.ToString("t");
            txtEndDatePP.Text = SelectedPlan.EndDate.ToString("t");
            txtName.Text = SelectedEvent.Name;
            txtTheme.Text = SelectedEvent.StraniVariTheme;
            txtStartDate.Text = SelectedEvent.StartDate.ToString("D");
            txtEndDate.Text = SelectedEvent.EndDate.ToString("D");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
