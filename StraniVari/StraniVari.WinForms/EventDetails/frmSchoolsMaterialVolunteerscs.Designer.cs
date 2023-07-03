namespace StraniVari.WinUI.EventDetails
{
    partial class frmSchoolsMaterialVolunteerscs
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvMaterialForSchool = new DataGridView();
            Check = new DataGridViewCheckBoxColumn();
            SchoolMaterialId = new DataGridViewTextBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvVolunteers = new DataGridView();
            SchoolVolunteerId = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            VolunteerAddress = new DataGridViewTextBoxColumn();
            VolunteerCity = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialForSchool).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(53, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(418, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 63);
            label1.Name = "label1";
            label1.Size = new Size(461, 50);
            label1.TabIndex = 88;
            label1.Text = "Schools";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMaterialForSchool);
            groupBox1.Location = new Point(50, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 259);
            groupBox1.TabIndex = 89;
            groupBox1.TabStop = false;
            // 
            // dgvMaterialForSchool
            // 
            dgvMaterialForSchool.AllowUserToAddRows = false;
            dgvMaterialForSchool.AllowUserToDeleteRows = false;
            dgvMaterialForSchool.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMaterialForSchool.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialForSchool.Columns.AddRange(new DataGridViewColumn[] { Check, SchoolMaterialId, MaterialName });
            dgvMaterialForSchool.Cursor = Cursors.Hand;
            dgvMaterialForSchool.Dock = DockStyle.Fill;
            dgvMaterialForSchool.Location = new Point(3, 23);
            dgvMaterialForSchool.Name = "dgvMaterialForSchool";
            dgvMaterialForSchool.RowHeadersWidth = 51;
            dgvMaterialForSchool.RowTemplate.Height = 29;
            dgvMaterialForSchool.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterialForSchool.Size = new Size(418, 233);
            dgvMaterialForSchool.TabIndex = 0;
            // 
            // Check
            // 
            Check.DataPropertyName = "IsChecked";
            Check.HeaderText = "";
            Check.MinimumWidth = 6;
            Check.Name = "Check";
            Check.Width = 50;
            // 
            // SchoolMaterialId
            // 
            SchoolMaterialId.DataPropertyName = "id";
            SchoolMaterialId.HeaderText = "SchoolMaterialId";
            SchoolMaterialId.MinimumWidth = 6;
            SchoolMaterialId.Name = "SchoolMaterialId";
            SchoolMaterialId.Visible = false;
            SchoolMaterialId.Width = 125;
            // 
            // MaterialName
            // 
            MaterialName.DataPropertyName = "name";
            MaterialName.HeaderText = "Name";
            MaterialName.MinimumWidth = 6;
            MaterialName.Name = "MaterialName";
            MaterialName.ReadOnly = true;
            MaterialName.Width = 280;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 194);
            label2.Name = "label2";
            label2.Size = new Size(461, 50);
            label2.TabIndex = 90;
            label2.Text = "Material";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvVolunteers);
            groupBox2.Location = new Point(50, 561);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(893, 375);
            groupBox2.TabIndex = 91;
            groupBox2.TabStop = false;
            // 
            // dgvVolunteers
            // 
            dgvVolunteers.AllowUserToAddRows = false;
            dgvVolunteers.AllowUserToDeleteRows = false;
            dgvVolunteers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvVolunteers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVolunteers.Columns.AddRange(new DataGridViewColumn[] { SchoolVolunteerId, FirstName, LastName, VolunteerAddress, VolunteerCity });
            dgvVolunteers.Cursor = Cursors.Hand;
            dgvVolunteers.Dock = DockStyle.Fill;
            dgvVolunteers.Location = new Point(3, 23);
            dgvVolunteers.Name = "dgvVolunteers";
            dgvVolunteers.ReadOnly = true;
            dgvVolunteers.RowHeadersWidth = 51;
            dgvVolunteers.RowTemplate.Height = 29;
            dgvVolunteers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVolunteers.Size = new Size(887, 349);
            dgvVolunteers.TabIndex = 0;
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
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 190;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 190;
            // 
            // VolunteerAddress
            // 
            VolunteerAddress.DataPropertyName = "Address";
            VolunteerAddress.HeaderText = "Address";
            VolunteerAddress.MinimumWidth = 6;
            VolunteerAddress.Name = "VolunteerAddress";
            VolunteerAddress.ReadOnly = true;
            VolunteerAddress.Width = 250;
            // 
            // VolunteerCity
            // 
            VolunteerCity.DataPropertyName = "City";
            VolunteerCity.HeaderText = "City";
            VolunteerCity.MinimumWidth = 6;
            VolunteerCity.Name = "VolunteerCity";
            VolunteerCity.ReadOnly = true;
            VolunteerCity.Width = 190;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 508);
            label3.Name = "label3";
            label3.Size = new Size(461, 50);
            label3.TabIndex = 92;
            label3.Text = "Volunteers";
            // 
            // frmSchoolsMaterialVolunteerscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1144, 948);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "frmSchoolsMaterialVolunteerscs";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmSchoolsMaterialVolunteerscs_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterialForSchool).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvMaterialForSchool;
        private Label label2;
        private DataGridViewCheckBoxColumn Check;
        private DataGridViewTextBoxColumn SchoolMaterialId;
        private DataGridViewTextBoxColumn MaterialName;
        private GroupBox groupBox2;
        private DataGridView dgvVolunteers;
        private DataGridViewTextBoxColumn SchoolVolunteerId;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn VolunteerAddress;
        private DataGridViewTextBoxColumn VolunteerCity;
        private Label label3;
    }
}