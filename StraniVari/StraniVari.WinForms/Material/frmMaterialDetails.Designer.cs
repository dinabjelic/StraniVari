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
            label4 = new Label();
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtTheme = new TextBox();
            txtName = new TextBox();
            txtSchool = new TextBox();
            groupBox1 = new GroupBox();
            dgvMaterialForSchool = new DataGridView();
            SchoolMaterialId = new DataGridViewTextBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialForSchool).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(649, 59);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 13;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(409, 377);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(225, 19);
            txtEndDate.TabIndex = 12;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(409, 424);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(225, 19);
            txtStartDate.TabIndex = 11;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(409, 332);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(225, 19);
            txtTheme.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(409, 297);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(225, 19);
            txtName.TabIndex = 9;
            // 
            // txtSchool
            // 
            txtSchool.BorderStyle = BorderStyle.None;
            txtSchool.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchool.Location = new Point(409, 460);
            txtSchool.Name = "txtSchool";
            txtSchool.ReadOnly = true;
            txtSchool.Size = new Size(225, 19);
            txtSchool.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMaterialForSchool);
            groupBox1.Location = new Point(670, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 379);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "EVENT DETAILS";
            // 
            // dgvMaterialForSchool
            // 
            dgvMaterialForSchool.AllowUserToAddRows = false;
            dgvMaterialForSchool.AllowUserToDeleteRows = false;
            dgvMaterialForSchool.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialForSchool.Columns.AddRange(new DataGridViewColumn[] { SchoolMaterialId, MaterialName, Quantity, Action, btnDelete });
            dgvMaterialForSchool.Cursor = Cursors.Hand;
            dgvMaterialForSchool.Dock = DockStyle.Fill;
            dgvMaterialForSchool.Location = new Point(3, 23);
            dgvMaterialForSchool.Name = "dgvMaterialForSchool";
            dgvMaterialForSchool.ReadOnly = true;
            dgvMaterialForSchool.RowHeadersWidth = 51;
            dgvMaterialForSchool.RowTemplate.Height = 29;
            dgvMaterialForSchool.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterialForSchool.Size = new Size(615, 353);
            dgvMaterialForSchool.TabIndex = 0;
            dgvMaterialForSchool.CellContentClick += dgvMaterialForSchool_CellContentClick;
            // 
            // SchoolMaterialId
            // 
            SchoolMaterialId.DataPropertyName = "SchoolMaterialId";
            SchoolMaterialId.HeaderText = "SchoolMaterialId";
            SchoolMaterialId.MinimumWidth = 6;
            SchoolMaterialId.Name = "SchoolMaterialId";
            SchoolMaterialId.ReadOnly = true;
            SchoolMaterialId.Visible = false;
            SchoolMaterialId.Width = 125;
            // 
            // MaterialName
            // 
            MaterialName.DataPropertyName = "MaterialName";
            MaterialName.HeaderText = "Material Name";
            MaterialName.MinimumWidth = 6;
            MaterialName.Name = "MaterialName";
            MaterialName.ReadOnly = true;
            MaterialName.Width = 250;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
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
            // frmMaterialDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(groupBox1);
            Controls.Add(txtSchool);
            Controls.Add(label4);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtTheme);
            Controls.Add(txtName);
            Name = "frmMaterialDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMaterialDetails";
            Load += frmMaterialDetails_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterialForSchool).EndInit();
            ResumeLayout(false);
            PerformLayout();
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