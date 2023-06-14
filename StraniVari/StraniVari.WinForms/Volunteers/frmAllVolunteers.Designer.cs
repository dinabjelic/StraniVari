namespace StraniVari.WinUI.Volunteers
{
    partial class frmAllVolunteers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllVolunteers));
            btnAddVolunteer = new Button();
            groupBox1 = new GroupBox();
            dgvVolunteers = new DataGridView();
            SchoolVolunteerId = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            VolunteerAddress = new DataGridViewTextBoxColumn();
            VolunteerCity = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddVolunteer
            // 
            btnAddVolunteer.Cursor = Cursors.Hand;
            btnAddVolunteer.Location = new Point(1387, 160);
            btnAddVolunteer.Name = "btnAddVolunteer";
            btnAddVolunteer.Size = new Size(135, 29);
            btnAddVolunteer.TabIndex = 20;
            btnAddVolunteer.Text = "Add volunteer";
            btnAddVolunteer.UseVisualStyleBackColor = true;
            btnAddVolunteer.Click += btnAddVolunteer_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvVolunteers);
            groupBox1.Location = new Point(461, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1064, 375);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "EVENT DETAILS";
            // 
            // dgvVolunteers
            // 
            dgvVolunteers.AllowUserToAddRows = false;
            dgvVolunteers.AllowUserToDeleteRows = false;
            dgvVolunteers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVolunteers.Columns.AddRange(new DataGridViewColumn[] { SchoolVolunteerId, FirstName, LastName, VolunteerAddress, VolunteerCity, btnEdit, btnDelete });
            dgvVolunteers.Cursor = Cursors.Hand;
            dgvVolunteers.Dock = DockStyle.Fill;
            dgvVolunteers.Location = new Point(3, 23);
            dgvVolunteers.Name = "dgvVolunteers";
            dgvVolunteers.ReadOnly = true;
            dgvVolunteers.RowHeadersWidth = 51;
            dgvVolunteers.RowTemplate.Height = 29;
            dgvVolunteers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVolunteers.Size = new Size(1058, 349);
            dgvVolunteers.TabIndex = 0;
            dgvVolunteers.CellContentClick += dgvVolunteers_CellContentClick;
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
            // btnEdit
            // 
            btnEdit.HeaderText = "Action";
            btnEdit.MinimumWidth = 6;
            btnEdit.Name = "btnEdit";
            btnEdit.ReadOnly = true;
            btnEdit.Text = "Edit";
            btnEdit.ToolTipText = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 90;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(71, 218);
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
            label4.Location = new Point(390, 66);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 77;
            // 
            // frmAllVolunteers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(btnAddVolunteer);
            Name = "frmAllVolunteers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllVolunteers";
            Load += frmAllVolunteers_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddVolunteer;
        private GroupBox groupBox1;
        private DataGridView dgvVolunteers;
        private DataGridViewTextBoxColumn SchoolVolunteerId;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn VolunteerAddress;
        private DataGridViewTextBoxColumn VolunteerCity;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
        private PictureBox pictureBox2;
        private Label label4;
    }
}