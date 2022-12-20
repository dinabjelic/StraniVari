namespace StraniVari.WinUI.Volunteers
{
    partial class frmVolunteerDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVolunteers = new System.Windows.Forms.DataGridView();
            this.SchoolVolunteerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportNeeded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVolunteers);
            this.groupBox1.Location = new System.Drawing.Point(276, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 269);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EVENT DETAILS";
            // 
            // dgvVolunteers
            // 
            this.dgvVolunteers.AllowUserToAddRows = false;
            this.dgvVolunteers.AllowUserToDeleteRows = false;
            this.dgvVolunteers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolunteers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolVolunteerId,
            this.FirstName,
            this.LastName,
            this.VolunteerAddress,
            this.VolunteerCity,
            this.TransportNeeded,
            this.btnEdit,
            this.btnDelete});
            this.dgvVolunteers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvVolunteers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVolunteers.Location = new System.Drawing.Point(3, 23);
            this.dgvVolunteers.Name = "dgvVolunteers";
            this.dgvVolunteers.ReadOnly = true;
            this.dgvVolunteers.RowHeadersWidth = 51;
            this.dgvVolunteers.RowTemplate.Height = 29;
            this.dgvVolunteers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVolunteers.Size = new System.Drawing.Size(806, 243);
            this.dgvVolunteers.TabIndex = 0;
            this.dgvVolunteers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialForSchool_CellContentClick);
            // 
            // SchoolVolunteerId
            // 
            this.SchoolVolunteerId.DataPropertyName = "SchoolVolunteerId";
            this.SchoolVolunteerId.HeaderText = "SchoolVolunteerId";
            this.SchoolVolunteerId.MinimumWidth = 6;
            this.SchoolVolunteerId.Name = "SchoolVolunteerId";
            this.SchoolVolunteerId.ReadOnly = true;
            this.SchoolVolunteerId.Visible = false;
            this.SchoolVolunteerId.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // VolunteerAddress
            // 
            this.VolunteerAddress.DataPropertyName = "VolunteerAddress";
            this.VolunteerAddress.HeaderText = "VolunteerAddress";
            this.VolunteerAddress.MinimumWidth = 6;
            this.VolunteerAddress.Name = "VolunteerAddress";
            this.VolunteerAddress.ReadOnly = true;
            this.VolunteerAddress.Width = 130;
            // 
            // VolunteerCity
            // 
            this.VolunteerCity.DataPropertyName = "VolunteerCity";
            this.VolunteerCity.HeaderText = "VolunteerCity";
            this.VolunteerCity.MinimumWidth = 6;
            this.VolunteerCity.Name = "VolunteerCity";
            this.VolunteerCity.ReadOnly = true;
            this.VolunteerCity.Width = 125;
            // 
            // TransportNeeded
            // 
            this.TransportNeeded.DataPropertyName = "TransportNeeded";
            this.TransportNeeded.HeaderText = "TransportNeeded";
            this.TransportNeeded.MinimumWidth = 6;
            this.TransportNeeded.Name = "TransportNeeded";
            this.TransportNeeded.ReadOnly = true;
            this.TransportNeeded.Width = 130;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Action";
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ToolTipText = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            this.btnEdit.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Action";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 125;
            // 
            // txtSchool
            // 
            this.txtSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSchool.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSchool.Location = new System.Drawing.Point(26, 296);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.ReadOnly = true;
            this.txtSchool.Size = new System.Drawing.Size(225, 19);
            this.txtSchool.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(257, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 408);
            this.label4.TabIndex = 31;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDate.Location = new System.Drawing.Point(26, 213);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(225, 19);
            this.txtEndDate.TabIndex = 30;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDate.Location = new System.Drawing.Point(26, 260);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(225, 19);
            this.txtStartDate.TabIndex = 29;
            // 
            // txtTheme
            // 
            this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheme.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheme.Location = new System.Drawing.Point(26, 168);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(225, 19);
            this.txtTheme.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(26, 133);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(225, 19);
            this.txtName.TabIndex = 27;
            // 
            // frmVolunteerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtName);
            this.Name = "frmVolunteerDetails";
            this.Text = "frmVolunteerDetails";
            this.Load += new System.EventHandler(this.frmVolunteerDetails_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvVolunteers;
        private TextBox txtSchool;
        private Label label4;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtTheme;
        private TextBox txtName;
        private DataGridViewTextBoxColumn SchoolVolunteerId;
        private DataGridViewCheckBoxColumn TransportNeeded;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn VolunteerAddress;
        private DataGridViewTextBoxColumn VolunteerCity;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}