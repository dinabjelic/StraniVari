namespace StraniVari.WinUI.Admin
{
    partial class frmUsersTab
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
            sideBar1 = new Material.SideBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            dgvVolunteers = new DataGridView();
            SchoolVolunteerId = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            VolunteerAddress = new DataGridViewTextBoxColumn();
            VolunteerCity = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnAddVolunteer = new Button();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            dgvAdmins = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            btnAddAdmin = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.Location = new Point(0, -4);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(390, 1142);
            sideBar1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(406, 83);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1031, 485);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnAddVolunteer);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1023, 452);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Volunteers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvVolunteers);
            groupBox1.Location = new Point(15, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(990, 375);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            // 
            // dgvVolunteers
            // 
            dgvVolunteers.AllowUserToAddRows = false;
            dgvVolunteers.AllowUserToDeleteRows = false;
            dgvVolunteers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvVolunteers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVolunteers.Columns.AddRange(new DataGridViewColumn[] { SchoolVolunteerId, FirstName, LastName, VolunteerAddress, VolunteerCity, btnDelete });
            dgvVolunteers.Cursor = Cursors.Hand;
            dgvVolunteers.Dock = DockStyle.Fill;
            dgvVolunteers.Location = new Point(3, 23);
            dgvVolunteers.Name = "dgvVolunteers";
            dgvVolunteers.ReadOnly = true;
            dgvVolunteers.RowHeadersWidth = 51;
            dgvVolunteers.RowTemplate.Height = 29;
            dgvVolunteers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVolunteers.Size = new Size(984, 349);
            dgvVolunteers.TabIndex = 0;
            dgvVolunteers.CellContentClick += dgvVolunteers_CellContentClick_1;
            dgvVolunteers.CellMouseDoubleClick += dgvVolunteers_CellMouseDoubleClick_1;
            // 
            // SchoolVolunteerId
            // 
            SchoolVolunteerId.DataPropertyName = "SchoolVolunteerId";
            SchoolVolunteerId.HeaderText = "SchoolVolunteerId";
            SchoolVolunteerId.MinimumWidth = 6;
            SchoolVolunteerId.Name = "SchoolVolunteerId";
            SchoolVolunteerId.ReadOnly = true;
            SchoolVolunteerId.Visible = false;
            SchoolVolunteerId.Width = 125;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 190;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 190;
            // 
            // VolunteerAddress
            // 
            VolunteerAddress.DataPropertyName = "Address";
            VolunteerAddress.HeaderText = "Address";
            VolunteerAddress.MinimumWidth = 6;
            VolunteerAddress.Name = "VolunteerAddress";
            VolunteerAddress.ReadOnly = true;
            VolunteerAddress.Width = 250;
            // 
            // VolunteerCity
            // 
            VolunteerCity.DataPropertyName = "City";
            VolunteerCity.HeaderText = "City";
            VolunteerCity.MinimumWidth = 6;
            VolunteerCity.Name = "VolunteerCity";
            VolunteerCity.ReadOnly = true;
            VolunteerCity.Width = 190;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Action";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.ToolTipText = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 90;
            // 
            // btnAddVolunteer
            // 
            btnAddVolunteer.BackColor = SystemColors.Window;
            btnAddVolunteer.Cursor = Cursors.Hand;
            btnAddVolunteer.Location = new Point(858, 20);
            btnAddVolunteer.Name = "btnAddVolunteer";
            btnAddVolunteer.Size = new Size(135, 29);
            btnAddVolunteer.TabIndex = 36;
            btnAddVolunteer.Text = "Add volunteer";
            btnAddVolunteer.UseVisualStyleBackColor = false;
            btnAddVolunteer.Click += btnAddVolunteer_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(btnAddAdmin);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1023, 452);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Administrators";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvAdmins);
            groupBox2.Location = new Point(17, 55);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(983, 375);
            groupBox2.TabIndex = 82;
            groupBox2.TabStop = false;
            // 
            // dgvAdmins
            // 
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewButtonColumn1 });
            dgvAdmins.Cursor = Cursors.Hand;
            dgvAdmins.Dock = DockStyle.Fill;
            dgvAdmins.Location = new Point(3, 23);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.ReadOnly = true;
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.RowTemplate.Height = 29;
            dgvAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdmins.Size = new Size(977, 349);
            dgvAdmins.TabIndex = 0;
            dgvAdmins.CellContentClick += dgvAdmins_CellContentClick;
            dgvAdmins.CellMouseDoubleClick += dgvAdmins_CellMouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "SchoolVolunteerId";
            dataGridViewTextBoxColumn1.HeaderText = "SchoolVolunteerId";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 190;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn3.HeaderText = "LastName";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 190;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            dataGridViewTextBoxColumn4.HeaderText = "Address";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "City";
            dataGridViewTextBoxColumn5.HeaderText = "City";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 190;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "Action";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Text = "Delete";
            dataGridViewButtonColumn1.ToolTipText = "Delete";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 90;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.White;
            btnAddAdmin.Cursor = Cursors.Hand;
            btnAddAdmin.Location = new Point(840, 20);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(160, 29);
            btnAddAdmin.TabIndex = 81;
            btnAddAdmin.Text = "Add administrator";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // frmUsersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1460, 611);
            Controls.Add(tabControl1);
            Controls.Add(sideBar1);
            Name = "frmUsersTab";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmUsersTab_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Material.SideBar sideBar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAddVolunteer;
        private GroupBox groupBox2;
        private DataGridView dgvAdmins;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Button btnAddAdmin;
        private GroupBox groupBox1;
        private DataGridView dgvVolunteers;
        private DataGridViewTextBoxColumn SchoolVolunteerId;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn VolunteerAddress;
        private DataGridViewTextBoxColumn VolunteerCity;
        private DataGridViewButtonColumn btnDelete;
    }
}