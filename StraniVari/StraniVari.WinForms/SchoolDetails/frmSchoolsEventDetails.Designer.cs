namespace StraniVari.WinUI.SchoolDetails
{
    partial class frmSchoolsEventDetails
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
            dgvSchoolsEventDetails = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            SchoolName = new DataGridViewTextBoxColumn();
            SchoolAddress = new DataGridViewTextBoxColumn();
            SchoolCity = new DataGridViewTextBoxColumn();
            NumberOfChildren = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnAddMaterial = new DataGridViewButtonColumn();
            btnAddVolunteers = new DataGridViewButtonColumn();
            txtName = new TextBox();
            txtTheme = new TextBox();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchoolsEventDetails).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvSchoolsEventDetails);
            groupBox1.Location = new Point(387, 277);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1125, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EVENT DETAILS";
            // 
            // dgvSchoolsEventDetails
            // 
            dgvSchoolsEventDetails.AllowUserToAddRows = false;
            dgvSchoolsEventDetails.AllowUserToDeleteRows = false;
            dgvSchoolsEventDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchoolsEventDetails.Columns.AddRange(new DataGridViewColumn[] { Id, SchoolName, SchoolAddress, SchoolCity, NumberOfChildren, Action, btnDelete, btnAddMaterial, btnAddVolunteers });
            dgvSchoolsEventDetails.Cursor = Cursors.Hand;
            dgvSchoolsEventDetails.Dock = DockStyle.Fill;
            dgvSchoolsEventDetails.Location = new Point(3, 23);
            dgvSchoolsEventDetails.Name = "dgvSchoolsEventDetails";
            dgvSchoolsEventDetails.ReadOnly = true;
            dgvSchoolsEventDetails.RowHeadersWidth = 51;
            dgvSchoolsEventDetails.RowTemplate.Height = 29;
            dgvSchoolsEventDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchoolsEventDetails.Size = new Size(1119, 243);
            dgvSchoolsEventDetails.TabIndex = 0;
            dgvSchoolsEventDetails.CellContentClick += dgvSchoolsEventDetails_CellContentClick_1;
            // 
            // Id
            // 
            Id.DataPropertyName = "SchoolEventId";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // SchoolName
            // 
            SchoolName.DataPropertyName = "SchoolName";
            SchoolName.HeaderText = "School Name";
            SchoolName.MinimumWidth = 6;
            SchoolName.Name = "SchoolName";
            SchoolName.ReadOnly = true;
            SchoolName.Width = 180;
            // 
            // SchoolAddress
            // 
            SchoolAddress.DataPropertyName = "SchoolAddress";
            SchoolAddress.HeaderText = "School Address";
            SchoolAddress.MinimumWidth = 6;
            SchoolAddress.Name = "SchoolAddress";
            SchoolAddress.ReadOnly = true;
            SchoolAddress.Width = 180;
            // 
            // SchoolCity
            // 
            SchoolCity.DataPropertyName = "SchoolCity";
            SchoolCity.HeaderText = "School City";
            SchoolCity.MinimumWidth = 6;
            SchoolCity.Name = "SchoolCity";
            SchoolCity.ReadOnly = true;
            SchoolCity.Width = 125;
            // 
            // NumberOfChildren
            // 
            NumberOfChildren.DataPropertyName = "NumberOfChildren";
            NumberOfChildren.HeaderText = "Children Number";
            NumberOfChildren.MinimumWidth = 10;
            NumberOfChildren.Name = "NumberOfChildren";
            NumberOfChildren.ReadOnly = true;
            NumberOfChildren.Width = 160;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Resizable = DataGridViewTriState.True;
            Action.SortMode = DataGridViewColumnSortMode.Automatic;
            Action.Text = "Edit";
            Action.ToolTipText = "Edit";
            Action.UseColumnTextForButtonValue = true;
            Action.Width = 90;
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
            btnAddMaterial.HeaderText = "Action";
            btnAddMaterial.MinimumWidth = 6;
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.ReadOnly = true;
            btnAddMaterial.Text = "Add material";
            btnAddMaterial.ToolTipText = "Add material";
            btnAddMaterial.UseColumnTextForButtonValue = true;
            btnAddMaterial.Width = 120;
            // 
            // btnAddVolunteers
            // 
            btnAddVolunteers.HeaderText = "Action";
            btnAddVolunteers.MinimumWidth = 6;
            btnAddVolunteers.Name = "btnAddVolunteers";
            btnAddVolunteers.ReadOnly = true;
            btnAddVolunteers.Text = "Add Volunteers";
            btnAddVolunteers.ToolTipText = "Add Volunteers";
            btnAddVolunteers.UseColumnTextForButtonValue = true;
            btnAddVolunteers.Width = 120;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(129, 334);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(225, 19);
            txtName.TabIndex = 2;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(129, 369);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(225, 19);
            txtTheme.TabIndex = 3;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(129, 461);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(225, 19);
            txtStartDate.TabIndex = 4;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(129, 414);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(225, 19);
            txtEndDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(360, 83);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 8;
            // 
            // frmSchoolsEventDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(label4);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtTheme);
            Controls.Add(txtName);
            Controls.Add(groupBox1);
            Cursor = Cursors.Hand;
            Name = "frmSchoolsEventDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSchoolsEventDetails";
            Load += frmSchoolsEventDetails_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchoolsEventDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvSchoolsEventDetails;
        private TextBox txtName;
        private TextBox txtTheme;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private Label label4;
        private DataGridViewButtonColumn editNumberOfChildren;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SchoolName;
        private DataGridViewTextBoxColumn SchoolAddress;
        private DataGridViewTextBoxColumn SchoolCity;
        private DataGridViewTextBoxColumn NumberOfChildren;
        private DataGridViewButtonColumn Action;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewButtonColumn btnAddMaterial;
        private DataGridViewButtonColumn btnAddVolunteers;
    }
}