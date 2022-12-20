namespace StraniVari.WinUI.Material
{
    partial class frmMaterialDetails
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMaterialForSchool = new System.Windows.Forms.DataGridView();
            this.SchoolMaterialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialForSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(272, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 408);
            this.label4.TabIndex = 13;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDate.Location = new System.Drawing.Point(41, 199);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(225, 19);
            this.txtEndDate.TabIndex = 12;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDate.Location = new System.Drawing.Point(41, 246);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(225, 19);
            this.txtStartDate.TabIndex = 11;
            // 
            // txtTheme
            // 
            this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheme.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheme.Location = new System.Drawing.Point(41, 154);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(225, 19);
            this.txtTheme.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(41, 119);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(225, 19);
            this.txtName.TabIndex = 9;
            // 
            // txtSchool
            // 
            this.txtSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSchool.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSchool.Location = new System.Drawing.Point(41, 282);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.ReadOnly = true;
            this.txtSchool.Size = new System.Drawing.Size(225, 19);
            this.txtSchool.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMaterialForSchool);
            this.groupBox1.Location = new System.Drawing.Point(279, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 269);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EVENT DETAILS";
            // 
            // dgvMaterialForSchool
            // 
            this.dgvMaterialForSchool.AllowUserToAddRows = false;
            this.dgvMaterialForSchool.AllowUserToDeleteRows = false;
            this.dgvMaterialForSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialForSchool.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolMaterialId,
            this.MaterialName,
            this.Quantity,
            this.Action,
            this.btnDelete});
            this.dgvMaterialForSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMaterialForSchool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterialForSchool.Location = new System.Drawing.Point(3, 23);
            this.dgvMaterialForSchool.Name = "dgvMaterialForSchool";
            this.dgvMaterialForSchool.ReadOnly = true;
            this.dgvMaterialForSchool.RowHeadersWidth = 51;
            this.dgvMaterialForSchool.RowTemplate.Height = 29;
            this.dgvMaterialForSchool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialForSchool.Size = new System.Drawing.Size(556, 243);
            this.dgvMaterialForSchool.TabIndex = 0;
            this.dgvMaterialForSchool.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialForSchool_CellContentClick);
            // 
            // SchoolMaterialId
            // 
            this.SchoolMaterialId.DataPropertyName = "SchoolMaterialId";
            this.SchoolMaterialId.HeaderText = "SchoolMaterialId";
            this.SchoolMaterialId.MinimumWidth = 6;
            this.SchoolMaterialId.Name = "SchoolMaterialId";
            this.SchoolMaterialId.ReadOnly = true;
            this.SchoolMaterialId.Visible = false;
            this.SchoolMaterialId.Width = 125;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "MaterialName";
            this.MaterialName.MinimumWidth = 6;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            this.MaterialName.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
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
            // frmMaterialDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtName);
            this.Name = "frmMaterialDetails";
            this.Text = "frmMaterialDetails";
            this.Load += new System.EventHandler(this.frmMaterialDetails_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialForSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtTheme;
        private TextBox txtName;
        private TextBox txtSchool;
        private GroupBox groupBox1;
        private DataGridView dgvMaterialForSchool;
        private DataGridViewTextBoxColumn SchoolMaterialId;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewButtonColumn Action;
        private DataGridViewButtonColumn btnDelete;
    }
}