namespace StraniVari.WinUI.EventDetails
{
    partial class frmEventTabs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            dgvPlanAndProgramme = new DataGridView();
            tabPage1 = new TabPage();
            btnNotification = new Button();
            groupBox1 = new GroupBox();
            dgvNotifications = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            MeetingTheme = new DataGridViewTextBoxColumn();
            MeetingPlace = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            MeetingDate = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            Option = new DataGridViewButtonColumn();
            Action = new DataGridViewButtonColumn();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanAndProgramme).BeginInit();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(48, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1108, 449);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAdd);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1100, 416);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Plan and programme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Snow;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(887, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 29);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPlanAndProgramme);
            groupBox2.Location = new Point(122, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(887, 334);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            // 
            // dgvPlanAndProgramme
            // 
            dgvPlanAndProgramme.AllowUserToAddRows = false;
            dgvPlanAndProgramme.AllowUserToDeleteRows = false;
            dgvPlanAndProgramme.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPlanAndProgramme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanAndProgramme.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, StartDate, EndDate, Option, Action });
            dgvPlanAndProgramme.Cursor = Cursors.Hand;
            dgvPlanAndProgramme.Dock = DockStyle.Fill;
            dgvPlanAndProgramme.Location = new Point(3, 23);
            dgvPlanAndProgramme.Name = "dgvPlanAndProgramme";
            dgvPlanAndProgramme.ReadOnly = true;
            dgvPlanAndProgramme.RowHeadersWidth = 51;
            dgvPlanAndProgramme.RowTemplate.Height = 29;
            dgvPlanAndProgramme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlanAndProgramme.Size = new Size(881, 308);
            dgvPlanAndProgramme.TabIndex = 0;
            dgvPlanAndProgramme.CellContentClick += dgvPlanAndProgramme_CellContentClick;
            dgvPlanAndProgramme.CellMouseDoubleClick += dgvPlanAndProgramme_CellMouseDoubleClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNotification);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1100, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Notifications";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNotification
            // 
            btnNotification.BackColor = Color.White;
            btnNotification.Cursor = Cursors.Hand;
            btnNotification.Location = new Point(926, 64);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(158, 29);
            btnNotification.TabIndex = 19;
            btnNotification.Text = "Add notification";
            btnNotification.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvNotifications);
            groupBox1.Location = new Point(6, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1081, 262);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // dgvNotifications
            // 
            dgvNotifications.AllowUserToAddRows = false;
            dgvNotifications.AllowUserToDeleteRows = false;
            dgvNotifications.BackgroundColor = SystemColors.ButtonHighlight;
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifications.Columns.AddRange(new DataGridViewColumn[] { Id, MeetingTheme, MeetingPlace, Address, City, MeetingDate, btnEdit, btnDelete });
            dgvNotifications.Cursor = Cursors.Hand;
            dgvNotifications.Dock = DockStyle.Fill;
            dgvNotifications.Location = new Point(3, 23);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.ReadOnly = true;
            dgvNotifications.RowHeadersWidth = 51;
            dgvNotifications.RowTemplate.Height = 29;
            dgvNotifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotifications.Size = new Size(1075, 236);
            dgvNotifications.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // MeetingTheme
            // 
            MeetingTheme.DataPropertyName = "meetingTheme";
            MeetingTheme.HeaderText = "Meeting Theme";
            MeetingTheme.MinimumWidth = 6;
            MeetingTheme.Name = "MeetingTheme";
            MeetingTheme.ReadOnly = true;
            MeetingTheme.Width = 200;
            // 
            // MeetingPlace
            // 
            MeetingPlace.DataPropertyName = "meetingPlace";
            MeetingPlace.HeaderText = "Meeting Place";
            MeetingPlace.MinimumWidth = 6;
            MeetingPlace.Name = "MeetingPlace";
            MeetingPlace.ReadOnly = true;
            MeetingPlace.Width = 250;
            // 
            // Address
            // 
            Address.DataPropertyName = "address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 125;
            // 
            // City
            // 
            City.DataPropertyName = "city";
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.ReadOnly = true;
            City.Width = 125;
            // 
            // MeetingDate
            // 
            MeetingDate.DataPropertyName = "meetingDate";
            MeetingDate.HeaderText = "Meeting Date";
            MeetingDate.MinimumWidth = 6;
            MeetingDate.Name = "MeetingDate";
            MeetingDate.ReadOnly = true;
            MeetingDate.Width = 135;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Options";
            btnEdit.MinimumWidth = 6;
            btnEdit.Name = "btnEdit";
            btnEdit.ReadOnly = true;
            btnEdit.Resizable = DataGridViewTriState.True;
            btnEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEdit.Text = "Edit";
            btnEdit.ToolTipText = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 90;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Options";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.ToolTipText = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 90;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1100, 416);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Applications";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1100, 416);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "EventSchools";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // StartDate
            // 
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "Start Date";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            StartDate.Width = 240;
            // 
            // EndDate
            // 
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "End Date";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            EndDate.Width = 240;
            // 
            // Option
            // 
            Option.HeaderText = "Activities";
            Option.MinimumWidth = 6;
            Option.Name = "Option";
            Option.ReadOnly = true;
            Option.Resizable = DataGridViewTriState.True;
            Option.SortMode = DataGridViewColumnSortMode.Automatic;
            Option.Text = "Activities";
            Option.ToolTipText = "Activities";
            Option.UseColumnTextForButtonValue = true;
            Option.Width = 220;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Resizable = DataGridViewTriState.True;
            Action.SortMode = DataGridViewColumnSortMode.Automatic;
            Action.Text = "Delete";
            Action.ToolTipText = "Delete";
            Action.UseColumnTextForButtonValue = true;
            Action.Width = 125;
            // 
            // frmEventTabs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1196, 537);
            Controls.Add(tabControl1);
            Name = "frmEventTabs";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmEventTabs_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlanAndProgramme).EndInit();
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button btnNotification;
        private GroupBox groupBox1;
        private DataGridView dgvNotifications;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MeetingTheme;
        private DataGridViewTextBoxColumn MeetingPlace;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn MeetingDate;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
        private Button btnAdd;
        private GroupBox groupBox2;
        private DataGridView dgvPlanAndProgramme;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewButtonColumn Option;
        private DataGridViewButtonColumn Action;
    }
}