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
            btnAddTrip = new Button();
            groupBox1 = new GroupBox();
            dgvTrip = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Place = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddTrip
            // 
            btnAddTrip.Cursor = Cursors.Hand;
            btnAddTrip.Location = new Point(1281, 158);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(135, 29);
            btnAddTrip.TabIndex = 20;
            btnAddTrip.Text = "Add Trip";
            btnAddTrip.UseVisualStyleBackColor = true;
            btnAddTrip.Click += btnAddTrip_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvTrip);
            groupBox1.Location = new Point(573, 194);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(846, 389);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "TRIPS";
            // 
            // dgvTrip
            // 
            dgvTrip.AllowUserToAddRows = false;
            dgvTrip.AllowUserToDeleteRows = false;
            dgvTrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrip.Columns.AddRange(new DataGridViewColumn[] { Id, Place, DateTime, btnEdit, btnDelete });
            dgvTrip.Cursor = Cursors.Hand;
            dgvTrip.Dock = DockStyle.Fill;
            dgvTrip.Location = new Point(3, 24);
            dgvTrip.Margin = new Padding(3, 4, 3, 4);
            dgvTrip.Name = "dgvTrip";
            dgvTrip.ReadOnly = true;
            dgvTrip.RowHeadersWidth = 51;
            dgvTrip.RowTemplate.Height = 24;
            dgvTrip.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrip.Size = new Size(840, 361);
            dgvTrip.TabIndex = 0;
            dgvTrip.CellContentClick += dgvMaterial_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Place
            // 
            Place.DataPropertyName = "place";
            Place.HeaderText = "Place";
            Place.MinimumWidth = 6;
            Place.Name = "Place";
            Place.ReadOnly = true;
            Place.Width = 300;
            // 
            // DateTime
            // 
            DateTime.DataPropertyName = "TripDateTime";
            DateTime.HeaderText = "Date Time";
            DateTime.MinimumWidth = 8;
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            DateTime.Width = 300;
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
            pictureBox2.Location = new Point(179, 204);
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
            label4.Location = new Point(498, 52);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 77;
            // 
            // frmAllTrips
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(btnAddTrip);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmAllTrips";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllTrips";
            Load += frmAllTrips_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTrip;
        private GroupBox groupBox1;
        private DataGridView dgvTrip;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Place;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
        private PictureBox pictureBox2;
        private Label label4;
    }
}