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
            this.btnAddVolunteer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVolunteers = new System.Windows.Forms.DataGridView();
            this.SchoolVolunteerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddVolunteer
            // 
            this.btnAddVolunteer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVolunteer.Location = new System.Drawing.Point(849, 28);
            this.btnAddVolunteer.Name = "btnAddVolunteer";
            this.btnAddVolunteer.Size = new System.Drawing.Size(135, 29);
            this.btnAddVolunteer.TabIndex = 20;
            this.btnAddVolunteer.Text = "Add volunteer";
            this.btnAddVolunteer.UseVisualStyleBackColor = true;
            this.btnAddVolunteer.Click += new System.EventHandler(this.btnAddVolunteer_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(161, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 338);
            this.label3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVolunteers);
            this.groupBox1.Location = new System.Drawing.Point(178, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 269);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EVENT DETAILS";
            // 
            // dgvVolunteers
            // 
            this.dgvVolunteers.AllowUserToAddRows = false;
            this.dgvVolunteers.AllowUserToDeleteRows = false;
            this.dgvVolunteers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolunteers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolVolunteerId,
            this.FirstName,
            this.LastName,
            this.VolunteerAddress,
            this.VolunteerCity,
            this.btnEdit,
            this.btnDelete});
            this.dgvVolunteers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvVolunteers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVolunteers.Location = new System.Drawing.Point(3, 23);
            this.dgvVolunteers.Name = "dgvVolunteers";
            this.dgvVolunteers.ReadOnly = true;
            this.dgvVolunteers.RowHeadersWidth = 51;
            this.dgvVolunteers.RowTemplate.Height = 29;
            this.dgvVolunteers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVolunteers.Size = new System.Drawing.Size(806, 243);
            this.dgvVolunteers.TabIndex = 0;
            this.dgvVolunteers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVolunteers_CellContentClick);
            // 
            // SchoolVolunteerId
            // 
            this.SchoolVolunteerId.DataPropertyName = "SchoolVolunteerId";
            this.SchoolVolunteerId.HeaderText = "SchoolVolunteerId";
            this.SchoolVolunteerId.MinimumWidth = 6;
            this.SchoolVolunteerId.Name = "SchoolVolunteerId";
            this.SchoolVolunteerId.ReadOnly = true;
            this.SchoolVolunteerId.Visible = false;
            this.SchoolVolunteerId.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // VolunteerAddress
            // 
            this.VolunteerAddress.DataPropertyName = "Address";
            this.VolunteerAddress.HeaderText = "Address";
            this.VolunteerAddress.MinimumWidth = 6;
            this.VolunteerAddress.Name = "VolunteerAddress";
            this.VolunteerAddress.ReadOnly = true;
            this.VolunteerAddress.Width = 130;
            // 
            // VolunteerCity
            // 
            this.VolunteerCity.DataPropertyName = "City";
            this.VolunteerCity.HeaderText = "City";
            this.VolunteerCity.MinimumWidth = 6;
            this.VolunteerCity.Name = "VolunteerCity";
            this.VolunteerCity.ReadOnly = true;
            this.VolunteerCity.Width = 125;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Action";
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ToolTipText = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            this.btnEdit.Width = 125;
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
            // frmAllVolunteers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddVolunteer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAllVolunteers";
            this.Text = "frmAllVolunteers";
            this.Load += new System.EventHandler(this.frmAllVolunteers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddVolunteer;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private DataGridView dgvVolunteers;
        private DataGridViewTextBoxColumn SchoolVolunteerId;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn VolunteerAddress;
        private DataGridViewTextBoxColumn VolunteerCity;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}