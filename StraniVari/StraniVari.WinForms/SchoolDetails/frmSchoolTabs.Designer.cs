namespace StraniVari.WinUI.SchoolDetails
{
    partial class frmSchoolTabs
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            dgvVolunteers = new DataGridView();
            SchoolVolunteerId = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            VolunteerAddress = new DataGridViewTextBoxColumn();
            VolunteerCity = new DataGridViewTextBoxColumn();
            TransportNeeded = new DataGridViewCheckBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            dgvMaterialForSchool = new DataGridView();
            SchoolMaterialId = new DataGridViewTextBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            lblSchoolName = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialForSchool).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(42, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1134, 448);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1126, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Volunteers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvVolunteers);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(16, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1080, 313);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            // 
            // dgvVolunteers
            // 
            dgvVolunteers.AllowUserToAddRows = false;
            dgvVolunteers.AllowUserToDeleteRows = false;
            dgvVolunteers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvVolunteers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVolunteers.Columns.AddRange(new DataGridViewColumn[] { SchoolVolunteerId, FirstName, LastName, VolunteerAddress, VolunteerCity, TransportNeeded, btnDelete });
            dgvVolunteers.Cursor = Cursors.Hand;
            dgvVolunteers.Dock = DockStyle.Fill;
            dgvVolunteers.Location = new Point(3, 23);
            dgvVolunteers.Name = "dgvVolunteers";
            dgvVolunteers.ReadOnly = true;
            dgvVolunteers.RowHeadersWidth = 51;
            dgvVolunteers.RowTemplate.Height = 29;
            dgvVolunteers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVolunteers.Size = new Size(1074, 287);
            dgvVolunteers.TabIndex = 0;
            dgvVolunteers.CellContentClick += dgvVolunteers_CellContentClick;
            dgvVolunteers.CellMouseDoubleClick += dgvVolunteers_CellMouseDoubleClick;
            // 
            // SchoolVolunteerId
            // 
            SchoolVolunteerId.DataPropertyName = "SchoolVolunteerId";
            SchoolVolunteerId.HeaderText = "SchoolVolunteerId";
            SchoolVolunteerId.MinimumWidth = 6;
            SchoolVolunteerId.Name = "SchoolVolunteerId";
            SchoolVolunteerId.ReadOnly = true;
            SchoolVolunteerId.Visible = false;
            SchoolVolunteerId.Width = 125;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 190;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 190;
            // 
            // VolunteerAddress
            // 
            VolunteerAddress.DataPropertyName = "VolunteerAddress";
            VolunteerAddress.HeaderText = "Address";
            VolunteerAddress.MinimumWidth = 6;
            VolunteerAddress.Name = "VolunteerAddress";
            VolunteerAddress.ReadOnly = true;
            VolunteerAddress.Width = 220;
            // 
            // VolunteerCity
            // 
            VolunteerCity.DataPropertyName = "VolunteerCity";
            VolunteerCity.HeaderText = "City";
            VolunteerCity.MinimumWidth = 6;
            VolunteerCity.Name = "VolunteerCity";
            VolunteerCity.ReadOnly = true;
            VolunteerCity.Width = 190;
            // 
            // TransportNeeded
            // 
            TransportNeeded.DataPropertyName = "TransportNeeded";
            TransportNeeded.HeaderText = "TransportNeeded";
            TransportNeeded.MinimumWidth = 6;
            TransportNeeded.Name = "TransportNeeded";
            TransportNeeded.ReadOnly = true;
            TransportNeeded.Width = 125;
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1126, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Material";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMaterialForSchool);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(258, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(531, 379);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            // 
            // dgvMaterialForSchool
            // 
            dgvMaterialForSchool.AllowUserToAddRows = false;
            dgvMaterialForSchool.AllowUserToDeleteRows = false;
            dgvMaterialForSchool.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMaterialForSchool.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialForSchool.Columns.AddRange(new DataGridViewColumn[] { SchoolMaterialId, MaterialName, Quantity, dataGridViewButtonColumn1 });
            dgvMaterialForSchool.Cursor = Cursors.Hand;
            dgvMaterialForSchool.Dock = DockStyle.Fill;
            dgvMaterialForSchool.Location = new Point(3, 23);
            dgvMaterialForSchool.Name = "dgvMaterialForSchool";
            dgvMaterialForSchool.ReadOnly = true;
            dgvMaterialForSchool.RowHeadersWidth = 51;
            dgvMaterialForSchool.RowTemplate.Height = 29;
            dgvMaterialForSchool.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterialForSchool.Size = new Size(525, 353);
            dgvMaterialForSchool.TabIndex = 0;
            dgvMaterialForSchool.CellContentClick += dgvMaterialForSchool_CellContentClick;
            dgvMaterialForSchool.CellMouseDoubleClick += dgvMaterialForSchool_CellMouseDoubleClick;
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
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "Action";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Text = "Delete";
            dataGridViewButtonColumn1.ToolTipText = "Delete";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 90;
            // 
            // lblSchoolName
            // 
            lblSchoolName.Font = new Font("Sitka Small", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSchoolName.ForeColor = SystemColors.ControlText;
            lblSchoolName.Location = new Point(42, 14);
            lblSchoolName.Name = "lblSchoolName";
            lblSchoolName.Size = new Size(443, 50);
            lblSchoolName.TabIndex = 90;
            lblSchoolName.Text = "Prva osnovna skola";
            // 
            // frmSchoolTabs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1212, 541);
            Controls.Add(lblSchoolName);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "frmSchoolTabs";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmSchoolTabs_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterialForSchool).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private DataGridView dgvVolunteers;
        private DataGridViewTextBoxColumn SchoolVolunteerId;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn VolunteerAddress;
        private DataGridViewTextBoxColumn VolunteerCity;
        private DataGridViewCheckBoxColumn TransportNeeded;
        private DataGridViewButtonColumn btnDelete;
        private GroupBox groupBox2;
        private DataGridView dgvMaterialForSchool;
        private DataGridViewTextBoxColumn SchoolMaterialId;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Label lblSchoolName;
    }
}