namespace StraniVari.WinUI.Applications
{
    partial class frmAllApplications
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
            txtSchool = new TextBox();
            label3 = new Label();
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtName = new TextBox();
            txtTheme = new TextBox();
            label1 = new Label();
            txtTripPlace = new TextBox();
            txtTripDatTime = new TextBox();
            groupBox1 = new GroupBox();
            dgvApplications = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            VolunteerName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // txtSchool
            // 
            txtSchool.BorderStyle = BorderStyle.None;
            txtSchool.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchool.Location = new Point(278, 388);
            txtSchool.Name = "txtSchool";
            txtSchool.ReadOnly = true;
            txtSchool.Size = new Size(268, 19);
            txtSchool.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuText;
            label3.Location = new Point(600, 275);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 30;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(278, 358);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(268, 19);
            txtEndDate.TabIndex = 29;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(278, 324);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(268, 19);
            txtStartDate.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(278, 259);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(268, 19);
            txtName.TabIndex = 25;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(278, 292);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(268, 19);
            txtTheme.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 204);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 28;
            // 
            // txtTripPlace
            // 
            txtTripPlace.BorderStyle = BorderStyle.None;
            txtTripPlace.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTripPlace.Location = new Point(278, 413);
            txtTripPlace.Name = "txtTripPlace";
            txtTripPlace.ReadOnly = true;
            txtTripPlace.Size = new Size(268, 19);
            txtTripPlace.TabIndex = 33;
            // 
            // txtTripDatTime
            // 
            txtTripDatTime.BorderStyle = BorderStyle.None;
            txtTripDatTime.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTripDatTime.Location = new Point(278, 438);
            txtTripDatTime.Name = "txtTripDatTime";
            txtTripDatTime.ReadOnly = true;
            txtTripDatTime.Size = new Size(268, 19);
            txtTripDatTime.TabIndex = 34;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvApplications);
            groupBox1.Location = new Point(600, 171);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(815, 376);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "APPLICATIONS";
            // 
            // dgvApplications
            // 
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AllowUserToDeleteRows = false;
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Columns.AddRange(new DataGridViewColumn[] { Id, VolunteerName, LastName, Status, btnEdit });
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
            dgvApplications.CellContentClick += dgvApplications_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
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
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(573, 47);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 31;
            // 
            // frmAllApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(groupBox1);
            Controls.Add(txtTripDatTime);
            Controls.Add(txtTripPlace);
            Controls.Add(txtSchool);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtName);
            Controls.Add(txtTheme);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmAllApplications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllApplications";
            Load += frmAllApplications_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSchool;
        private Label label3;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtName;
        private TextBox txtTheme;
        private Label label1;
        private TextBox txtTripPlace;
        private TextBox txtTripDatTime;
        private GroupBox groupBox1;
        private DataGridView dgvApplications;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn VolunteerName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn btnEdit;
        private Label label4;
    }
}