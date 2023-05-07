namespace StraniVari.WinUI.Trip
{
    partial class frmAllTrips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllTrips));
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTrip = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrip.Location = new System.Drawing.Point(700, 67);
            this.btnAddTrip.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(169, 36);
            this.btnAddTrip.TabIndex = 20;
            this.btnAddTrip.Text = "Add Trip";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(238, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 304);
            this.label3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTrip);
            this.groupBox1.Location = new System.Drawing.Point(280, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(589, 188);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRIPS";
            // 
            // dgvTrip
            // 
            this.dgvTrip.AllowUserToAddRows = false;
            this.dgvTrip.AllowUserToDeleteRows = false;
            this.dgvTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Place,
            this.DateTime,
            this.btnEdit,
            this.btnDelete});
            this.dgvTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrip.Location = new System.Drawing.Point(4, 29);
            this.dgvTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTrip.Name = "dgvTrip";
            this.dgvTrip.ReadOnly = true;
            this.dgvTrip.RowHeadersWidth = 51;
            this.dgvTrip.RowTemplate.Height = 24;
            this.dgvTrip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrip.Size = new System.Drawing.Size(581, 154);
            this.dgvTrip.TabIndex = 0;
            this.dgvTrip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "place";
            this.Place.HeaderText = "Place";
            this.Place.MinimumWidth = 6;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Width = 125;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "TripDateTime";
            this.DateTime.HeaderText = "Date Time";
            this.DateTime.MinimumWidth = 8;
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Width = 150;
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
            // frmAllTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 424);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAllTrips";
            this.Text = "frmAllTrips";
            this.Load += new System.EventHandler(this.frmAllTrips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddTrip;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private DataGridView dgvTrip;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Place;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}