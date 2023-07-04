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
            IsChecked = new DataGridViewCheckBoxColumn();
            SchoolMaterialId = new DataGridViewTextBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            NumberOfMaterial = new DataGridViewTextBoxColumn();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvVolunteers = new DataGridView();
            SchoolVolunteerId = new DataGridViewTextBoxColumn();
            Checked = new DataGridViewCheckBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            VolunteerAddress = new DataGridViewTextBoxColumn();
            VolunteerCity = new DataGridViewTextBoxColumn();
            Transport = new DataGridViewCheckBoxColumn();
            label3 = new Label();
            button1 = new Button();
            games1 = new Reports.Games();
            label4 = new Label();
            txtNumberOfChildren = new TextBox();
            label5 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialForSchool).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)games1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(418, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(461, 50);
            label1.TabIndex = 88;
            label1.Text = "Schools";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMaterialForSchool);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(15, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 259);
            groupBox1.TabIndex = 89;
            groupBox1.TabStop = false;
            // 
            // dgvMaterialForSchool
            // 
            dgvMaterialForSchool.AllowUserToAddRows = false;
            dgvMaterialForSchool.AllowUserToDeleteRows = false;
            dgvMaterialForSchool.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMaterialForSchool.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialForSchool.Columns.AddRange(new DataGridViewColumn[] { IsChecked, SchoolMaterialId, MaterialName, NumberOfMaterial });
            dgvMaterialForSchool.Cursor = Cursors.Hand;
            dgvMaterialForSchool.Dock = DockStyle.Fill;
            dgvMaterialForSchool.Location = new Point(3, 23);
            dgvMaterialForSchool.Name = "dgvMaterialForSchool";
            dgvMaterialForSchool.RowHeadersWidth = 51;
            dgvMaterialForSchool.RowTemplate.Height = 29;
            dgvMaterialForSchool.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterialForSchool.Size = new Size(532, 233);
            dgvMaterialForSchool.TabIndex = 0;
            // 
            // IsChecked
            // 
            IsChecked.DataPropertyName = "IsChecked";
            IsChecked.HeaderText = "";
            IsChecked.MinimumWidth = 6;
            IsChecked.Name = "IsChecked";
            IsChecked.Width = 50;
            // 
            // SchoolMaterialId
            // 
            SchoolMaterialId.DataPropertyName = "Id";
            SchoolMaterialId.HeaderText = "SchoolMaterialId";
            SchoolMaterialId.MinimumWidth = 6;
            SchoolMaterialId.Name = "SchoolMaterialId";
            SchoolMaterialId.Visible = false;
            SchoolMaterialId.Width = 125;
            // 
            // MaterialName
            // 
            MaterialName.DataPropertyName = "Name";
            MaterialName.HeaderText = "Name";
            MaterialName.MinimumWidth = 6;
            MaterialName.Name = "MaterialName";
            MaterialName.ReadOnly = true;
            MaterialName.Width = 280;
            // 
            // NumberOfMaterial
            // 
            NumberOfMaterial.DataPropertyName = "NumberOfMaterial";
            NumberOfMaterial.HeaderText = "Material number";
            NumberOfMaterial.MinimumWidth = 6;
            NumberOfMaterial.Name = "NumberOfMaterial";
            NumberOfMaterial.Width = 125;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, -53);
            label2.Name = "label2";
            label2.Size = new Size(461, 50);
            label2.TabIndex = 90;
            label2.Text = "Material";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvVolunteers);
            groupBox2.Location = new Point(18, 584);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1055, 375);
            groupBox2.TabIndex = 91;
            groupBox2.TabStop = false;
            // 
            // dgvVolunteers
            // 
            dgvVolunteers.AllowUserToAddRows = false;
            dgvVolunteers.AllowUserToDeleteRows = false;
            dgvVolunteers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvVolunteers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVolunteers.Columns.AddRange(new DataGridViewColumn[] { SchoolVolunteerId, Checked, FirstName, LastName, VolunteerAddress, VolunteerCity, Transport });
            dgvVolunteers.Cursor = Cursors.Hand;
            dgvVolunteers.Dock = DockStyle.Fill;
            dgvVolunteers.Location = new Point(3, 23);
            dgvVolunteers.Name = "dgvVolunteers";
            dgvVolunteers.RowHeadersWidth = 51;
            dgvVolunteers.RowTemplate.Height = 29;
            dgvVolunteers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVolunteers.Size = new Size(1049, 349);
            dgvVolunteers.TabIndex = 0;
            // 
            // SchoolVolunteerId
            // 
            SchoolVolunteerId.DataPropertyName = "SchoolVolunteerId";
            SchoolVolunteerId.HeaderText = "SchoolVolunteerId";
            SchoolVolunteerId.MinimumWidth = 6;
            SchoolVolunteerId.Name = "SchoolVolunteerId";
            SchoolVolunteerId.Visible = false;
            SchoolVolunteerId.Width = 125;
            // 
            // Checked
            // 
            Checked.DataPropertyName = "IsChecked";
            Checked.HeaderText = "";
            Checked.MinimumWidth = 6;
            Checked.Name = "Checked";
            Checked.Width = 50;
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
            VolunteerAddress.DataPropertyName = "VolunteerAddress";
            VolunteerAddress.HeaderText = "Address";
            VolunteerAddress.MinimumWidth = 6;
            VolunteerAddress.Name = "VolunteerAddress";
            VolunteerAddress.ReadOnly = true;
            VolunteerAddress.Width = 250;
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
            // Transport
            // 
            Transport.DataPropertyName = "TransportNeeded";
            Transport.HeaderText = "Transport needed";
            Transport.MinimumWidth = 6;
            Transport.Name = "Transport";
            Transport.Resizable = DataGridViewTriState.True;
            Transport.SortMode = DataGridViewColumnSortMode.Automatic;
            Transport.Width = 125;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 531);
            label3.Name = "label3";
            label3.Size = new Size(461, 50);
            label3.TabIndex = 92;
            label3.Text = "Volunteers";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(893, 983);
            button1.Name = "button1";
            button1.Size = new Size(177, 40);
            button1.TabIndex = 93;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // games1
            // 
            games1.DataSetName = "Games";
            games1.Namespace = "http://tempuri.org/Games.xsd";
            games1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 194);
            label4.Name = "label4";
            label4.Size = new Size(261, 50);
            label4.TabIndex = 94;
            label4.Text = "Materials";
            // 
            // txtNumberOfChildren
            // 
            txtNumberOfChildren.Location = new Point(479, 116);
            txtNumberOfChildren.Name = "txtNumberOfChildren";
            txtNumberOfChildren.Size = new Size(125, 27);
            txtNumberOfChildren.TabIndex = 95;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(479, 69);
            label5.Name = "label5";
            label5.Size = new Size(203, 37);
            label5.TabIndex = 96;
            label5.Text = "Number of children";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Location = new Point(339, 201);
            button2.Name = "button2";
            button2.Size = new Size(214, 29);
            button2.TabIndex = 97;
            button2.Text = "Recommend material";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmSchoolsMaterialVolunteerscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1097, 1035);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(txtNumberOfChildren);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)games1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvMaterialForSchool;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dgvVolunteers;
        private Label label3;
        private Button button1;
        private Reports.Games games1;
        private Label label4;
        private DataGridViewTextBoxColumn SchoolVolunteerId;
        private DataGridViewCheckBoxColumn Checked;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn VolunteerAddress;
        private DataGridViewTextBoxColumn VolunteerCity;
        private DataGridViewCheckBoxColumn Transport;
        private DataGridViewCheckBoxColumn IsChecked;
        private DataGridViewTextBoxColumn SchoolMaterialId;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewTextBoxColumn NumberOfMaterial;
        private TextBox txtNumberOfChildren;
        private Label label5;
        private Button button2;
    }
}