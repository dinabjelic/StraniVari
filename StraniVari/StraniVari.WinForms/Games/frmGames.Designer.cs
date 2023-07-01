namespace StraniVari.WinUI.Games
{
    partial class frmGames
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
            sideBar1 = new Material.SideBar();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvGames = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            SchoolName = new DataGridViewTextBoxColumn();
            btnDetails = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnAddGame = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Left;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(392, 626);
            sideBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(431, 94);
            label1.Name = "label1";
            label1.Size = new Size(179, 50);
            label1.TabIndex = 89;
            label1.Text = "Games";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvGames);
            groupBox1.Location = new Point(503, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 290);
            groupBox1.TabIndex = 90;
            groupBox1.TabStop = false;
            // 
            // dgvGames
            // 
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.BackgroundColor = SystemColors.ButtonHighlight;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Columns.AddRange(new DataGridViewColumn[] { Id, SchoolName, btnDetails, btnDelete });
            dgvGames.Cursor = Cursors.Hand;
            dgvGames.Dock = DockStyle.Fill;
            dgvGames.Location = new Point(3, 23);
            dgvGames.Name = "dgvGames";
            dgvGames.ReadOnly = true;
            dgvGames.RowHeadersWidth = 51;
            dgvGames.RowTemplate.Height = 29;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(576, 264);
            dgvGames.TabIndex = 0;
            dgvGames.CellContentClick += dgvGames_CellContentClick;
            dgvGames.MouseDoubleClick += dgvGames_MouseDoubleClick;
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
            SchoolName.Width = 300;
            // 
            // btnDetails
            // 
            btnDetails.HeaderText = "Details";
            btnDetails.MinimumWidth = 6;
            btnDetails.Name = "btnDetails";
            btnDetails.ReadOnly = true;
            btnDetails.Resizable = DataGridViewTriState.True;
            btnDetails.SortMode = DataGridViewColumnSortMode.Automatic;
            btnDetails.Text = "More";
            btnDetails.ToolTipText = "More";
            btnDetails.UseColumnTextForButtonValue = true;
            btnDetails.Width = 125;
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
            // btnAddGame
            // 
            btnAddGame.BackColor = SystemColors.Window;
            btnAddGame.Cursor = Cursors.Hand;
            btnAddGame.Location = new Point(936, 143);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(149, 29);
            btnAddGame.TabIndex = 91;
            btnAddGame.Text = "Add game";
            btnAddGame.UseVisualStyleBackColor = false;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // frmGames
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1195, 626);
            Controls.Add(btnAddGame);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(sideBar1);
            Name = "frmGames";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmGames_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Material.SideBar sideBar1;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvSchools;
        private DataGridView dgvGames;
        private DataGridViewButtonColumn More;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SchoolName;
        private DataGridViewButtonColumn btnDetails;
        private DataGridViewButtonColumn btnDelete;
        private Button btnAddGame;
    }
}