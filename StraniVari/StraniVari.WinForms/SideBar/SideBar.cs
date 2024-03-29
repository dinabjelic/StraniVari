﻿using StraniVari.WinUI.Admin;
using StraniVari.WinUI.EventDetails;
using StraniVari.WinUI.Games;
using StraniVari.WinUI.Login;
using StraniVari.WinUI.Reports;
using StraniVari.WinUI.SchoolDetails;
using StraniVari.WinUI.Service;
using StraniVari.WinUI.StartPage;
using StraniVari.WinUI.Trip;

namespace StraniVari.WinUI.Material
{
    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void CloseCurrentForm()
        {
            var openedForm = this.FindForm();
            openedForm.Close();
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            frmTripTabs frmAllTrips = new frmTripTabs();
            frmAllTrips.Show();
            CloseCurrentForm();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmAllMaterial frmAllMaterial = new frmAllMaterial();
            frmAllMaterial.Show();
            CloseCurrentForm();
        }

        private void SideBar_Load(object sender, EventArgs e)
        {
            Helpers.JWTDecoder.ShowUsername(lblName);
        }

        private void btnSchool_Click(object sender, EventArgs e)
        {
            frmAllSchools frmAllSchools = new frmAllSchools();
            frmAllSchools.Show();
            CloseCurrentForm();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            frmGames frmGames = new frmGames();
            frmGames.Show();
            CloseCurrentForm();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUsersTab frmUsersTab = new frmUsersTab();
            frmUsersTab.Show();
            CloseCurrentForm();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            frmAllEvents frmAllEvents = new frmAllEvents();
            frmAllEvents.Show();
            CloseCurrentForm();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReport frmGamesSchoolsReportscs = new frmReport();
            frmGamesSchoolsReportscs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApiService.Token = null;
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            CloseCurrentForm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmStartPage frmStartPage = new frmStartPage();
            frmStartPage.Show();
            CloseCurrentForm();
        }
    }
}
