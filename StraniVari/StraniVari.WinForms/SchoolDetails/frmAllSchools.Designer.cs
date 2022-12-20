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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSchools = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSchools);
            this.groupBox1.Location = new System.Drawing.Point(219, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EVENT DETAILS";
            // 
            // dgvSchools
            // 
            this.dgvSchools.AllowUserToAddRows = false;
            this.dgvSchools.AllowUserToDeleteRows = false;
            this.dgvSchools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SchoolName,
            this.Address,
            this.City,
            this.Action,
            this.btnDelete});
            this.dgvSchools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSchools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchools.Location = new System.Drawing.Point(3, 23);
            this.dgvSchools.Name = "dgvSchools";
            this.dgvSchools.ReadOnly = true;
            this.dgvSchools.RowHeadersWidth = 51;
            this.dgvSchools.RowTemplate.Height = 29;
            this.dgvSchools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchools.Size = new System.Drawing.Size(683, 243);
            this.dgvSchools.TabIndex = 0;
            this.dgvSchools.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchools_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "SchoolEventId";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // SchoolName
            // 
            this.SchoolName.DataPropertyName = "Name";
            this.SchoolName.HeaderText = "Name";
            this.SchoolName.MinimumWidth = 6;
            this.SchoolName.Name = "SchoolName";
            this.SchoolName.ReadOnly = true;
            this.SchoolName.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "Edit";
            this.Action.ToolTipText = "Edit";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 125;
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(187, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 338);
            this.label3.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSchool.Location = new System.Drawing.Point(792, 35);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(110, 29);
            this.btnAddSchool.TabIndex = 22;
            this.btnAddSchool.Text = "Add school";
            this.btnAddSchool.UseVisualStyleBackColor = true;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // frmAllSchools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 403);
            this.Controls.Add(this.btnAddSchool);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAllSchools";
            this.Text = "frmAllSchools";
            this.Load += new System.EventHandler(this.frmAllSchools_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvSchools;
        private DataGridViewTextBoxColumn SchoolAddress;
        private DataGridViewTextBoxColumn SchoolCity;
        private DataGridViewTextBoxColumn NumberOfChildren;
        private DataGridViewButtonColumn btnAddMaterial;
        private DataGridViewButtonColumn btnAddVolunteers;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnAddSchool;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SchoolName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewButtonColumn Action;
        private DataGridViewButtonColumn btnDelete;
    }
}