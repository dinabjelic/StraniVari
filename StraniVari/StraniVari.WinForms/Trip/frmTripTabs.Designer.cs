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
            lblName = new Label();
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
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            btnEvents = new Button();
            btnSchool = new Button();
            btnUser = new Button();
            btnMaterial = new Button();
            btnTrips = new Button();
            btnGames = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            groupBox2 = new GroupBox();
            dgvApplications = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            VolunteerName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrip).BeginInit();
            tabPage2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ButtonHighlight;
            lblName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(1466, 2);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 4;
            lblName.Text = "label1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(416, 72);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1152, 608);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAddTrip);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1144, 575);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Trips";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddTrip
            // 
            btnAddTrip.BackColor = Color.White;
            btnAddTrip.Cursor = Cursors.Hand;
            btnAddTrip.Location = new Point(878, 66);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(135, 29);
            btnAddTrip.TabIndex = 22;
            btnAddTrip.Text = "Add Trip";
            btnAddTrip.UseVisualStyleBackColor = false;
            btnAddTrip.Click += btnAddTrip_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvTrip);
            groupBox1.Location = new Point(112, 52);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(751, 488);
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
            dgvTrip.Size = new Size(745, 460);
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
            Place.Width = 300;
            // 
            // DateTime
            // 
            DateTime.DataPropertyName = "TripDateTime";
            DateTime.HeaderText = "Date Time";
            DateTime.MinimumWidth = 8;
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            DateTime.Width = 300;
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
            tabPage2.Size = new Size(1144, 575);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Applications";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(1459, 0);
            label3.Name = "label3";
            label3.Size = new Size(1, 25);
            label3.TabIndex = 46;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(btnEvents);
            flowLayoutPanel1.Controls.Add(btnSchool);
            flowLayoutPanel1.Controls.Add(btnUser);
            flowLayoutPanel1.Controls.Add(btnMaterial);
            flowLayoutPanel1.Controls.Add(btnTrips);
            flowLayoutPanel1.Controls.Add(btnGames);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Controls.Add(btnLogout);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(389, 731);
            flowLayoutPanel1.TabIndex = 47;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 63);
            panel3.TabIndex = 93;
            // 
            // btnEvents
            // 
            btnEvents.BackColor = SystemColors.GradientActiveCaption;
            btnEvents.Cursor = Cursors.Hand;
            btnEvents.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEvents.ForeColor = SystemColors.MenuText;
            btnEvents.Location = new Point(3, 72);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(386, 57);
            btnEvents.TabIndex = 88;
            btnEvents.Text = "Events";
            btnEvents.UseVisualStyleBackColor = false;
            // 
            // btnSchool
            // 
            btnSchool.BackColor = SystemColors.GradientActiveCaption;
            btnSchool.Cursor = Cursors.Hand;
            btnSchool.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchool.ForeColor = SystemColors.WindowText;
            btnSchool.Location = new Point(3, 135);
            btnSchool.Name = "btnSchool";
            btnSchool.Size = new Size(386, 55);
            btnSchool.TabIndex = 84;
            btnSchool.Text = "Schools";
            btnSchool.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.GradientActiveCaption;
            btnUser.Cursor = Cursors.Hand;
            btnUser.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = SystemColors.WindowText;
            btnUser.Location = new Point(3, 196);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(386, 53);
            btnUser.TabIndex = 85;
            btnUser.Text = "Users";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnMaterial
            // 
            btnMaterial.BackColor = SystemColors.GradientActiveCaption;
            btnMaterial.Cursor = Cursors.Hand;
            btnMaterial.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaterial.ForeColor = SystemColors.WindowText;
            btnMaterial.Location = new Point(3, 255);
            btnMaterial.Name = "btnMaterial";
            btnMaterial.Size = new Size(386, 48);
            btnMaterial.TabIndex = 87;
            btnMaterial.Text = "Materials";
            btnMaterial.UseVisualStyleBackColor = false;
            // 
            // btnTrips
            // 
            btnTrips.BackColor = SystemColors.GradientActiveCaption;
            btnTrips.Cursor = Cursors.Hand;
            btnTrips.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrips.ForeColor = SystemColors.WindowText;
            btnTrips.Location = new Point(0, 306);
            btnTrips.Margin = new Padding(0);
            btnTrips.Name = "btnTrips";
            btnTrips.Size = new Size(389, 58);
            btnTrips.TabIndex = 91;
            btnTrips.Text = "Trips";
            btnTrips.UseVisualStyleBackColor = false;
            // 
            // btnGames
            // 
            btnGames.BackColor = SystemColors.GradientActiveCaption;
            btnGames.Cursor = Cursors.Hand;
            btnGames.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGames.ForeColor = SystemColors.WindowText;
            btnGames.Location = new Point(3, 367);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(386, 56);
            btnGames.TabIndex = 86;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.GradientActiveCaption;
            btnReports.Cursor = Cursors.Hand;
            btnReports.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = SystemColors.WindowText;
            btnReports.Location = new Point(3, 429);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(386, 58);
            btnReports.TabIndex = 89;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.GradientActiveCaption;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(3, 493);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(386, 38);
            btnLogout.TabIndex = 94;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvApplications);
            groupBox2.Location = new Point(165, 99);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(815, 376);
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
            dgvApplications.Size = new Size(809, 348);
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
            // frmTripTabs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1638, 731);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(lblName);
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
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
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
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Button btnEvents;
        private Button btnSchool;
        private Button btnUser;
        private Button btnMaterial;
        private Button btnTrips;
        private Button btnGames;
        private Button btnReports;
        private Button btnLogout;
        private GroupBox groupBox2;
        private DataGridView dgvApplications;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn VolunteerName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn btnEdit;
        private Label label1;
    }
}