namespace StraniVari.WinUI.SchoolDetails
{
    partial class frmAllSchools
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
            dgvSchools = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            SchoolName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnAddSchool = new Button();
            sideBar1 = new Material.SideBar();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchools).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvSchools);
            groupBox1.Location = new Point(461, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(875, 388);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // dgvSchools
            // 
            dgvSchools.AllowUserToAddRows = false;
            dgvSchools.AllowUserToDeleteRows = false;
            dgvSchools.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSchools.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchools.Columns.AddRange(new DataGridViewColumn[] { Id, SchoolName, Address, City, btnDelete });
            dgvSchools.Cursor = Cursors.Hand;
            dgvSchools.Dock = DockStyle.Fill;
            dgvSchools.Location = new Point(3, 23);
            dgvSchools.Name = "dgvSchools";
            dgvSchools.ReadOnly = true;
            dgvSchools.RowHeadersWidth = 51;
            dgvSchools.RowTemplate.Height = 29;
            dgvSchools.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchools.Size = new Size(869, 362);
            dgvSchools.TabIndex = 0;
            dgvSchools.CellContentClick += dgvSchools_CellContentClick;
            dgvSchools.CellMouseDoubleClick += dgvSchools_CellMouseDoubleClick;
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
            SchoolName.DataPropertyName = "Name";
            SchoolName.HeaderText = "Name";
            SchoolName.MinimumWidth = 6;
            SchoolName.Name = "SchoolName";
            SchoolName.ReadOnly = true;
            SchoolName.Width = 240;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 240;
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.ReadOnly = true;
            City.Width = 240;
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
            // btnAddSchool
            // 
            btnAddSchool.BackColor = SystemColors.Window;
            btnAddSchool.Cursor = Cursors.Hand;
            btnAddSchool.Location = new Point(1209, 157);
            btnAddSchool.Name = "btnAddSchool";
            btnAddSchool.Size = new Size(127, 29);
            btnAddSchool.TabIndex = 22;
            btnAddSchool.Text = "Add school";
            btnAddSchool.UseVisualStyleBackColor = false;
            btnAddSchool.Click += btnAddSchool_Click;
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Left;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(391, 647);
            sideBar1.TabIndex = 23;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(461, 71);
            label1.Name = "label1";
            label1.Size = new Size(179, 50);
            label1.TabIndex = 88;
            label1.Text = "Schools";
            // 
            // frmAllSchools
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1381, 647);
            Controls.Add(label1);
            Controls.Add(sideBar1);
            Controls.Add(btnAddSchool);
            Controls.Add(groupBox1);
            Name = "frmAllSchools";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAllSchools_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchools).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvSchools;
        private DataGridViewTextBoxColumn SchoolAddress;
        private DataGridViewTextBoxColumn SchoolCity;
        private DataGridViewTextBoxColumn NumberOfChildren;
        private DataGridViewButtonColumn btnAddMaterial;
        private DataGridViewButtonColumn btnAddVolunteers;
        private Button btnAddSchool;
        private Material.SideBar sideBar1;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SchoolName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewButtonColumn btnDelete;
    }
}