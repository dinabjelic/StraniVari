namespace StraniVari.WinUI.PlanAndProgramme
{
    partial class frmAllPlanAndProgramme
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
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtTheme = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dgvPlanAndProgramme = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            Option = new DataGridViewButtonColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanAndProgramme).BeginInit();
            SuspendLayout();
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(404, 399);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(217, 19);
            txtEndDate.TabIndex = 39;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(404, 446);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(217, 19);
            txtStartDate.TabIndex = 38;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(404, 354);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(217, 19);
            txtTheme.TabIndex = 37;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(404, 319);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(217, 19);
            txtName.TabIndex = 36;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(639, 88);
            label3.Name = "label3";
            label3.Size = new Size(1, 644);
            label3.TabIndex = 40;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPlanAndProgramme);
            groupBox1.Location = new Point(670, 242);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(857, 334);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plan and Programme";
            // 
            // dgvPlanAndProgramme
            // 
            dgvPlanAndProgramme.AllowUserToAddRows = false;
            dgvPlanAndProgramme.AllowUserToDeleteRows = false;
            dgvPlanAndProgramme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanAndProgramme.Columns.AddRange(new DataGridViewColumn[] { Id, StartDate, EndDate, Option, btnEdit });
            dgvPlanAndProgramme.Cursor = Cursors.Hand;
            dgvPlanAndProgramme.Dock = DockStyle.Fill;
            dgvPlanAndProgramme.Location = new Point(3, 23);
            dgvPlanAndProgramme.Name = "dgvPlanAndProgramme";
            dgvPlanAndProgramme.ReadOnly = true;
            dgvPlanAndProgramme.RowHeadersWidth = 51;
            dgvPlanAndProgramme.RowTemplate.Height = 29;
            dgvPlanAndProgramme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlanAndProgramme.Size = new Size(851, 308);
            dgvPlanAndProgramme.TabIndex = 0;
            dgvPlanAndProgramme.CellContentClick += dgvPlanAndProgramme_CellContentClick;
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
            // StartDate
            // 
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "Start Date";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            StartDate.Width = 240;
            // 
            // EndDate
            // 
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "End Date";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            EndDate.Width = 240;
            // 
            // Option
            // 
            Option.HeaderText = "Activities";
            Option.MinimumWidth = 6;
            Option.Name = "Option";
            Option.ReadOnly = true;
            Option.Resizable = DataGridViewTriState.True;
            Option.SortMode = DataGridViewColumnSortMode.Automatic;
            Option.Text = "Activities";
            Option.ToolTipText = "Activities";
            Option.UseColumnTextForButtonValue = true;
            Option.Width = 220;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Option";
            btnEdit.MinimumWidth = 6;
            btnEdit.Name = "btnEdit";
            btnEdit.ReadOnly = true;
            btnEdit.Text = "Edit";
            btnEdit.ToolTipText = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 90;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(1402, 207);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 29);
            btnAdd.TabIndex = 42;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAllPlanAndProgramme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtTheme);
            Controls.Add(txtName);
            Name = "frmAllPlanAndProgramme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllPlanAndProgramme";
            Load += frmAllPlanAndProgramme_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlanAndProgramme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtTheme;
        private TextBox txtName;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView dgvPlanAndProgramme;
        private Button btnAdd;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewButtonColumn Option;
        private DataGridViewButtonColumn btnEdit;
    }
}