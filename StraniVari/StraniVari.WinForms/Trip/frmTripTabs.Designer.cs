namespace StraniVari.WinUI.Trip
{
    partial class frmTripTabs
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
            tabPage1 = new TabPage();
            btnAddTrip = new Button();
            groupBox1 = new GroupBox();
            dgvTrip = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Place = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            dgvApplications = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            VolunteerName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            label1 = new Label();
            sideBar1 = new Material.SideBar();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrip).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(416, 72);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(765, 551);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAddTrip);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(757, 518);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Trips";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddTrip
            // 
            btnAddTrip.BackColor = Color.White;
            btnAddTrip.Cursor = Cursors.Hand;
            btnAddTrip.Location = new Point(572, 44);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(110, 29);
            btnAddTrip.TabIndex = 22;
            btnAddTrip.Text = "Add Trip";
            btnAddTrip.UseVisualStyleBackColor = false;
            btnAddTrip.Click += btnAddTrip_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvTrip);
            groupBox1.Location = new Point(33, 70);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(655, 393);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // dgvTrip
            // 
            dgvTrip.AllowUserToAddRows = false;
            dgvTrip.AllowUserToDeleteRows = false;
            dgvTrip.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrip.Columns.AddRange(new DataGridViewColumn[] { Id, Place, DateTime, btnDelete });
            dgvTrip.Cursor = Cursors.Hand;
            dgvTrip.Dock = DockStyle.Fill;
            dgvTrip.Location = new Point(3, 24);
            dgvTrip.Margin = new Padding(3, 4, 3, 4);
            dgvTrip.Name = "dgvTrip";
            dgvTrip.ReadOnly = true;
            dgvTrip.RowHeadersWidth = 51;
            dgvTrip.RowTemplate.Height = 24;
            dgvTrip.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrip.Size = new Size(649, 365);
            dgvTrip.TabIndex = 0;
            dgvTrip.CellContentClick += dgvTrip_CellContentClick;
            dgvTrip.MouseDoubleClick += dgvTrip_MouseDoubleClick;
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
            // Place
            // 
            Place.DataPropertyName = "place";
            Place.HeaderText = "Place";
            Place.MinimumWidth = 6;
            Place.Name = "Place";
            Place.ReadOnly = true;
            Place.Width = 250;
            // 
            // DateTime
            // 
            DateTime.DataPropertyName = "TripDateTime";
            DateTime.HeaderText = "Date Time";
            DateTime.MinimumWidth = 8;
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            DateTime.Width = 250;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(757, 518);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Applications";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvApplications);
            groupBox2.Location = new Point(6, 106);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(726, 376);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "APPLICATIONS";
            // 
            // dgvApplications
            // 
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AllowUserToDeleteRows = false;
            dgvApplications.BackgroundColor = SystemColors.ButtonHighlight;
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, VolunteerName, LastName, Status, btnEdit });
            dgvApplications.Cursor = Cursors.Hand;
            dgvApplications.Dock = DockStyle.Fill;
            dgvApplications.Location = new Point(3, 24);
            dgvApplications.Margin = new Padding(3, 4, 3, 4);
            dgvApplications.Name = "dgvApplications";
            dgvApplications.ReadOnly = true;
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.RowTemplate.Height = 24;
            dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.Size = new Size(720, 348);
            dgvApplications.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // VolunteerName
            // 
            VolunteerName.DataPropertyName = "VolunteerName";
            VolunteerName.HeaderText = "First name";
            VolunteerName.MinimumWidth = 6;
            VolunteerName.Name = "VolunteerName";
            VolunteerName.ReadOnly = true;
            VolunteerName.Width = 220;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "VolunteerLastName";
            LastName.HeaderText = "Last name";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 220;
            // 
            // Status
            // 
            Status.DataPropertyName = "status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 220;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Action";
            btnEdit.MinimumWidth = 6;
            btnEdit.Name = "btnEdit";
            btnEdit.ReadOnly = true;
            btnEdit.Text = "Edit";
            btnEdit.ToolTipText = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuText;
            label1.Location = new Point(165, 203);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 36;
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Left;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(390, 685);
            sideBar1.TabIndex = 6;
            // 
            // frmTripTabs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1212, 685);
            Controls.Add(sideBar1);
            Controls.Add(tabControl1);
            Name = "frmTripTabs";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmTripTabs_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrip).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAddTrip;
        private GroupBox groupBox1;
        private DataGridView dgvTrip;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Place;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewButtonColumn btnDelete;
        private GroupBox groupBox2;
        private DataGridView dgvApplications;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn VolunteerName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn btnEdit;
        private Label label1;
        private Material.SideBar sideBar1;
    }
}