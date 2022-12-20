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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSchoolsEventDetails = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfChildren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddMaterial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddVolunteers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolsEventDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSchoolsEventDetails);
            this.groupBox1.Location = new System.Drawing.Point(324, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1106, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EVENT DETAILS";
            // 
            // dgvSchoolsEventDetails
            // 
            this.dgvSchoolsEventDetails.AllowUserToAddRows = false;
            this.dgvSchoolsEventDetails.AllowUserToDeleteRows = false;
            this.dgvSchoolsEventDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolsEventDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SchoolName,
            this.SchoolAddress,
            this.SchoolCity,
            this.NumberOfChildren,
            this.Action,
            this.btnDelete,
            this.btnAddMaterial,
            this.btnAddVolunteers});
            this.dgvSchoolsEventDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSchoolsEventDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchoolsEventDetails.Location = new System.Drawing.Point(3, 23);
            this.dgvSchoolsEventDetails.Name = "dgvSchoolsEventDetails";
            this.dgvSchoolsEventDetails.ReadOnly = true;
            this.dgvSchoolsEventDetails.RowHeadersWidth = 51;
            this.dgvSchoolsEventDetails.RowTemplate.Height = 29;
            this.dgvSchoolsEventDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchoolsEventDetails.Size = new System.Drawing.Size(1100, 243);
            this.dgvSchoolsEventDetails.TabIndex = 0;
            this.dgvSchoolsEventDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchoolsEventDetails_CellContentClick_1);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(70, 149);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(225, 19);
            this.txtName.TabIndex = 2;
            // 
            // txtTheme
            // 
            this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheme.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheme.Location = new System.Drawing.Point(70, 184);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(225, 19);
            this.txtTheme.TabIndex = 3;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDate.Location = new System.Drawing.Point(70, 276);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(225, 19);
            this.txtStartDate.TabIndex = 4;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDate.Location = new System.Drawing.Point(70, 229);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(225, 19);
            this.txtEndDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(301, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 408);
            this.label4.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "SchoolEventId";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // SchoolName
            // 
            this.SchoolName.DataPropertyName = "SchoolName";
            this.SchoolName.HeaderText = "SchoolName";
            this.SchoolName.MinimumWidth = 6;
            this.SchoolName.Name = "SchoolName";
            this.SchoolName.ReadOnly = true;
            this.SchoolName.Width = 125;
            // 
            // SchoolAddress
            // 
            this.SchoolAddress.DataPropertyName = "SchoolAddress";
            this.SchoolAddress.HeaderText = "SchoolAddress";
            this.SchoolAddress.MinimumWidth = 6;
            this.SchoolAddress.Name = "SchoolAddress";
            this.SchoolAddress.ReadOnly = true;
            this.SchoolAddress.Width = 125;
            // 
            // SchoolCity
            // 
            this.SchoolCity.DataPropertyName = "SchoolCity";
            this.SchoolCity.HeaderText = "SchoolCity";
            this.SchoolCity.MinimumWidth = 6;
            this.SchoolCity.Name = "SchoolCity";
            this.SchoolCity.ReadOnly = true;
            this.SchoolCity.Width = 125;
            // 
            // NumberOfChildren
            // 
            this.NumberOfChildren.DataPropertyName = "NumberOfChildren";
            this.NumberOfChildren.HeaderText = "NumberOfChildren";
            this.NumberOfChildren.MinimumWidth = 10;
            this.NumberOfChildren.Name = "NumberOfChildren";
            this.NumberOfChildren.ReadOnly = true;
            this.NumberOfChildren.Width = 170;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "Edit";
            this.Action.ToolTipText = "Edit";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 125;
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
            // btnAddMaterial
            // 
            this.btnAddMaterial.HeaderText = "Action";
            this.btnAddMaterial.MinimumWidth = 6;
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.ReadOnly = true;
            this.btnAddMaterial.Text = "Add material";
            this.btnAddMaterial.ToolTipText = "Add material";
            this.btnAddMaterial.UseColumnTextForButtonValue = true;
            this.btnAddMaterial.Width = 125;
            // 
            // btnAddVolunteers
            // 
            this.btnAddVolunteers.HeaderText = "Action";
            this.btnAddVolunteers.MinimumWidth = 6;
            this.btnAddVolunteers.Name = "btnAddVolunteers";
            this.btnAddVolunteers.ReadOnly = true;
            this.btnAddVolunteers.Text = "Add Volunteers";
            this.btnAddVolunteers.ToolTipText = "Add Volunteers";
            this.btnAddVolunteers.UseColumnTextForButtonValue = true;
            this.btnAddVolunteers.Width = 125;
            // 
            // frmSchoolsEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmSchoolsEventDetails";
            this.Text = "frmSchoolsEventDetails";
            this.Load += new System.EventHandler(this.frmSchoolsEventDetails_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolsEventDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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