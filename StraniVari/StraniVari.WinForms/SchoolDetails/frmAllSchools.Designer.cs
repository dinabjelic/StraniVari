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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllSchools));
            groupBox1 = new GroupBox();
            dgvSchools = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            SchoolName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnAddSchool = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchools).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvSchools);
            groupBox1.Location = new Point(523, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(968, 388);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "EVENT DETAILS";
            // 
            // dgvSchools
            // 
            dgvSchools.AllowUserToAddRows = false;
            dgvSchools.AllowUserToDeleteRows = false;
            dgvSchools.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchools.Columns.AddRange(new DataGridViewColumn[] { Id, SchoolName, Address, City, Action, btnDelete });
            dgvSchools.Cursor = Cursors.Hand;
            dgvSchools.Dock = DockStyle.Fill;
            dgvSchools.Location = new Point(3, 23);
            dgvSchools.Name = "dgvSchools";
            dgvSchools.ReadOnly = true;
            dgvSchools.RowHeadersWidth = 51;
            dgvSchools.RowTemplate.Height = 29;
            dgvSchools.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchools.Size = new Size(962, 362);
            dgvSchools.TabIndex = 0;
            dgvSchools.CellContentClick += dgvSchools_CellContentClick;
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
            // btnAddSchool
            // 
            btnAddSchool.Cursor = Cursors.Hand;
            btnAddSchool.Location = new Point(1378, 145);
            btnAddSchool.Name = "btnAddSchool";
            btnAddSchool.Size = new Size(110, 29);
            btnAddSchool.TabIndex = 22;
            btnAddSchool.Text = "Add school";
            btnAddSchool.UseVisualStyleBackColor = true;
            btnAddSchool.Click += btnAddSchool_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(127, 203);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 330);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(446, 51);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 77;
            // 
            // frmAllSchools
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(btnAddSchool);
            Controls.Add(groupBox1);
            Name = "frmAllSchools";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllSchools";
            Load += frmAllSchools_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchools).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SchoolName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewButtonColumn Action;
        private DataGridViewButtonColumn btnDelete;
        private PictureBox pictureBox2;
        private Label label4;
    }
}