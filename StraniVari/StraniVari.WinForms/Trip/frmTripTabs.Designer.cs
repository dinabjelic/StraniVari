namespace StraniVari.WinUI.Trip
{
    partial class frmTripTabs
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
            btnAddTrip = new Button();
            groupBox1 = new GroupBox();
            dgvTrip = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Place = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            sideBar1 = new Material.SideBar();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrip).BeginInit();
            SuspendLayout();
            // 
            // btnAddTrip
            // 
            btnAddTrip.BackColor = Color.White;
            btnAddTrip.Cursor = Cursors.Hand;
            btnAddTrip.Location = new Point(1015, 149);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(110, 29);
            btnAddTrip.TabIndex = 22;
            btnAddTrip.Text = "Add Trip";
            btnAddTrip.UseVisualStyleBackColor = false;
            btnAddTrip.Click += btnAddTrip_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvTrip);
            groupBox1.Location = new Point(470, 185);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(655, 393);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // dgvTrip
            // 
            dgvTrip.AllowUserToAddRows = false;
            dgvTrip.AllowUserToDeleteRows = false;
            dgvTrip.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrip.Columns.AddRange(new DataGridViewColumn[] { Id, Place, DateTime, btnDelete });
            dgvTrip.Cursor = Cursors.Hand;
            dgvTrip.Dock = DockStyle.Fill;
            dgvTrip.Location = new Point(3, 24);
            dgvTrip.Margin = new Padding(3, 4, 3, 4);
            dgvTrip.Name = "dgvTrip";
            dgvTrip.ReadOnly = true;
            dgvTrip.RowHeadersWidth = 51;
            dgvTrip.RowTemplate.Height = 24;
            dgvTrip.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrip.Size = new Size(649, 365);
            dgvTrip.TabIndex = 0;
            dgvTrip.CellContentClick += dgvTrip_CellContentClick;
            dgvTrip.MouseDoubleClick += dgvTrip_MouseDoubleClick;
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
            Place.Width = 250;
            // 
            // DateTime
            // 
            DateTime.DataPropertyName = "TripDateTime";
            DateTime.HeaderText = "Date Time";
            DateTime.MinimumWidth = 8;
            DateTime.Name = "DateTime";
            DateTime.ReadOnly = true;
            DateTime.Width = 250;
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
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Left;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(390, 685);
            sideBar1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(460, 101);
            label1.Name = "label1";
            label1.Size = new Size(179, 50);
            label1.TabIndex = 88;
            label1.Text = "Trips";
            // 
            // frmTripTabs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1212, 685);
            Controls.Add(label1);
            Controls.Add(btnAddTrip);
            Controls.Add(sideBar1);
            Controls.Add(groupBox1);
            Name = "frmTripTabs";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmTripTabs_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrip).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddTrip;
        private GroupBox groupBox1;
        private DataGridView dgvTrip;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Place;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewButtonColumn btnDelete;
        private Material.SideBar sideBar1;
        private Label label1;
    }
}