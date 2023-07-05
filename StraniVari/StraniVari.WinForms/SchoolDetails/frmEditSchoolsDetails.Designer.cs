namespace StraniVari.WinUI.SchoolDetails
{
    partial class frmEditSchoolsDetails
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNumberofChildren = new Label();
            txtSchoolName = new TextBox();
            txtSchoolAddress = new TextBox();
            txtSchoolCity = new TextBox();
            txtNumberOfChildren = new TextBox();
            btnEditSchoolDetails = new Button();
            err = new ErrorProvider(components);
            groupBox2 = new GroupBox();
            dgvVolunteers = new DataGridView();
            SchoolVolunteerId = new DataGridViewTextBoxColumn();
            Checked = new DataGridViewCheckBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            VolunteerAddress = new DataGridViewTextBoxColumn();
            VolunteerCity = new DataGridViewTextBoxColumn();
            Transport = new DataGridViewCheckBoxColumn();
            label5 = new Label();
            groupBox1 = new GroupBox();
            dgvMaterialForSchool = new DataGridView();
            IsChecked = new DataGridViewCheckBoxColumn();
            SchoolMaterialId = new DataGridViewTextBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            NumberOfMaterial = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnRecMaterial = new Button();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialForSchool).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 98);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 14;
            label1.Text = "School name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 146);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 15;
            label2.Text = "School address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 187);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 16;
            label3.Text = "School city";
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(24, 235);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(138, 20);
            lblNumberofChildren.TabIndex = 17;
            lblNumberofChildren.Text = "Number of children";
            // 
            // txtSchoolName
            // 
            txtSchoolName.BackColor = SystemColors.ButtonHighlight;
            txtSchoolName.Location = new Point(168, 98);
            txtSchoolName.Name = "txtSchoolName";
            txtSchoolName.ReadOnly = true;
            txtSchoolName.Size = new Size(247, 27);
            txtSchoolName.TabIndex = 18;
            // 
            // txtSchoolAddress
            // 
            txtSchoolAddress.BackColor = SystemColors.ButtonHighlight;
            txtSchoolAddress.Location = new Point(168, 146);
            txtSchoolAddress.Name = "txtSchoolAddress";
            txtSchoolAddress.ReadOnly = true;
            txtSchoolAddress.Size = new Size(247, 27);
            txtSchoolAddress.TabIndex = 19;
            // 
            // txtSchoolCity
            // 
            txtSchoolCity.BackColor = SystemColors.ButtonHighlight;
            txtSchoolCity.Location = new Point(168, 187);
            txtSchoolCity.Name = "txtSchoolCity";
            txtSchoolCity.ReadOnly = true;
            txtSchoolCity.Size = new Size(247, 27);
            txtSchoolCity.TabIndex = 20;
            // 
            // txtNumberOfChildren
            // 
            txtNumberOfChildren.Cursor = Cursors.Hand;
            txtNumberOfChildren.ForeColor = SystemColors.InfoText;
            txtNumberOfChildren.Location = new Point(168, 235);
            txtNumberOfChildren.Name = "txtNumberOfChildren";
            txtNumberOfChildren.Size = new Size(247, 27);
            txtNumberOfChildren.TabIndex = 21;
            txtNumberOfChildren.Text = "numbers only";
            txtNumberOfChildren.TextAlign = HorizontalAlignment.Center;
            txtNumberOfChildren.KeyPress += txtNumberOfChildren_KeyPress;
            // 
            // btnEditSchoolDetails
            // 
            btnEditSchoolDetails.BackColor = SystemColors.ButtonHighlight;
            btnEditSchoolDetails.Cursor = Cursors.Hand;
            btnEditSchoolDetails.Location = new Point(925, 944);
            btnEditSchoolDetails.Name = "btnEditSchoolDetails";
            btnEditSchoolDetails.Size = new Size(148, 50);
            btnEditSchoolDetails.TabIndex = 22;
            btnEditSchoolDetails.Text = "Save";
            btnEditSchoolDetails.UseVisualStyleBackColor = false;
            btnEditSchoolDetails.Click += btnEditSchoolDetails_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvVolunteers);
            groupBox2.Location = new Point(21, 612);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1055, 326);
            groupBox2.TabIndex = 92;
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
            dgvVolunteers.Size = new Size(1049, 300);
            dgvVolunteers.TabIndex = 0;
            dgvVolunteers.DataError += dgvVolunteers_DataError;
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
            // label5
            // 
            label5.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(423, 34);
            label5.Name = "label5";
            label5.Size = new Size(179, 50);
            label5.TabIndex = 93;
            label5.Text = "Edit details";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMaterialForSchool);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(24, 347);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 259);
            groupBox1.TabIndex = 94;
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
            dgvMaterialForSchool.DataError += dgvMaterialForSchool_DataError;
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
            // label4
            // 
            label4.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, -53);
            label4.Name = "label4";
            label4.Size = new Size(461, 50);
            label4.TabIndex = 90;
            label4.Text = "Material";
            // 
            // btnRecMaterial
            // 
            btnRecMaterial.BackColor = SystemColors.Window;
            btnRecMaterial.Cursor = Cursors.Hand;
            btnRecMaterial.Location = new Point(27, 297);
            btnRecMaterial.Name = "btnRecMaterial";
            btnRecMaterial.Size = new Size(238, 44);
            btnRecMaterial.TabIndex = 95;
            btnRecMaterial.Text = "Recommend material";
            btnRecMaterial.UseVisualStyleBackColor = false;
            btnRecMaterial.Click += btnRecMaterial_Click;
            // 
            // frmEditSchoolsDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1094, 1006);
            Controls.Add(btnRecMaterial);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(btnEditSchoolDetails);
            Controls.Add(txtNumberOfChildren);
            Controls.Add(txtSchoolCity);
            Controls.Add(txtSchoolAddress);
            Controls.Add(txtSchoolName);
            Controls.Add(lblNumberofChildren);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditSchoolsDetails";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmEditSchoolsDetails_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterialForSchool).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNumberofChildren;
        private TextBox txtSchoolName;
        private TextBox txtSchoolAddress;
        private TextBox txtSchoolCity;
        private TextBox txtNumberOfChildren;
        private Button btnEditSchoolDetails;
        private ErrorProvider err;
        private GroupBox groupBox2;
        private DataGridView dgvVolunteers;
        private DataGridViewTextBoxColumn SchoolVolunteerId;
        private DataGridViewCheckBoxColumn Checked;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn VolunteerAddress;
        private DataGridViewTextBoxColumn VolunteerCity;
        private DataGridViewCheckBoxColumn Transport;
        private Label label5;
        private GroupBox groupBox1;
        private DataGridView dgvMaterialForSchool;
        private DataGridViewCheckBoxColumn IsChecked;
        private DataGridViewTextBoxColumn SchoolMaterialId;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewTextBoxColumn NumberOfMaterial;
        private Label label4;
        private Button btnRecMaterial;
    }
}