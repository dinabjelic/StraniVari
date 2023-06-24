namespace StraniVari.WinUI.Material
{
    partial class frmAllMaterial
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
            groupBox1 = new GroupBox();
            dgvMaterial = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnAddMaterial = new Button();
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
            label4 = new Label();
            lblName = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMaterial);
            groupBox1.Location = new Point(624, 179);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(642, 366);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "MATERIAL";
            // 
            // dgvMaterial
            // 
            dgvMaterial.AllowUserToAddRows = false;
            dgvMaterial.AllowUserToDeleteRows = false;
            dgvMaterial.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterial.Columns.AddRange(new DataGridViewColumn[] { Id, MaterialName, btnEdit, btnDelete });
            dgvMaterial.Cursor = Cursors.Hand;
            dgvMaterial.Dock = DockStyle.Fill;
            dgvMaterial.Location = new Point(3, 24);
            dgvMaterial.Margin = new Padding(3, 4, 3, 4);
            dgvMaterial.Name = "dgvMaterial";
            dgvMaterial.ReadOnly = true;
            dgvMaterial.RowHeadersWidth = 51;
            dgvMaterial.RowTemplate.Height = 24;
            dgvMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterial.Size = new Size(636, 338);
            dgvMaterial.TabIndex = 0;
            dgvMaterial.CellContentClick += dgvMaterial_CellContentClick;
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
            // MaterialName
            // 
            MaterialName.DataPropertyName = "name";
            MaterialName.HeaderText = "Name";
            MaterialName.MinimumWidth = 6;
            MaterialName.Name = "MaterialName";
            MaterialName.ReadOnly = true;
            MaterialName.Width = 400;
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
            // btnAddMaterial
            // 
            btnAddMaterial.Cursor = Cursors.Hand;
            btnAddMaterial.Location = new Point(1282, 196);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(135, 29);
            btnAddMaterial.TabIndex = 16;
            btnAddMaterial.Text = "Add material";
            btnAddMaterial.UseVisualStyleBackColor = true;
            btnAddMaterial.Click += btnAddMaterial_Click;
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
            flowLayoutPanel1.Size = new Size(389, 777);
            flowLayoutPanel1.TabIndex = 81;
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
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1455, 7);
            label4.Name = "label4";
            label4.Size = new Size(1, 25);
            label4.TabIndex = 84;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ButtonHighlight;
            lblName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(1462, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 83;
            lblName.Text = "label1";
            // 
            // frmAllMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1638, 777);
            Controls.Add(label4);
            Controls.Add(lblName);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAddMaterial);
            Controls.Add(groupBox1);
            Name = "frmAllMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllMaterial";
            Load += frmAllMaterial_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvMaterial;
        private Button btnAddMaterial;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
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
        private Label label4;
        private Label lblName;
    }
}