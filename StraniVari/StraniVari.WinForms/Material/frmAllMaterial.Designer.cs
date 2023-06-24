namespace StraniVari.WinUI.Material
{
    partial class frmAllMaterial
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
            groupBox1 = new GroupBox();
            dgvMaterial = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnAddMaterial = new Button();
            label4 = new Label();
            lblName = new Label();
            sideBar1 = new SideBar();
            btnAddMat = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMaterial);
            groupBox1.Location = new Point(474, 186);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(582, 366);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // dgvMaterial
            // 
            dgvMaterial.AllowUserToAddRows = false;
            dgvMaterial.AllowUserToDeleteRows = false;
            dgvMaterial.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterial.Columns.AddRange(new DataGridViewColumn[] { Id, MaterialName, btnDelete });
            dgvMaterial.Cursor = Cursors.Hand;
            dgvMaterial.Dock = DockStyle.Fill;
            dgvMaterial.Location = new Point(3, 24);
            dgvMaterial.Margin = new Padding(3, 4, 3, 4);
            dgvMaterial.Name = "dgvMaterial";
            dgvMaterial.ReadOnly = true;
            dgvMaterial.RowHeadersWidth = 51;
            dgvMaterial.RowTemplate.Height = 24;
            dgvMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterial.Size = new Size(576, 338);
            dgvMaterial.TabIndex = 0;
            dgvMaterial.CellContentClick += dgvMaterial_CellContentClick;
            dgvMaterial.MouseDoubleClick += dgvMaterial_MouseDoubleClick;
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
            // MaterialName
            // 
            MaterialName.DataPropertyName = "name";
            MaterialName.HeaderText = "Name";
            MaterialName.MinimumWidth = 6;
            MaterialName.Name = "MaterialName";
            MaterialName.ReadOnly = true;
            MaterialName.Width = 400;
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
            // btnAddMaterial
            // 
            btnAddMaterial.BackColor = SystemColors.Window;
            btnAddMaterial.Cursor = Cursors.Hand;
            btnAddMaterial.Location = new Point(1212, 203);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(135, 29);
            btnAddMaterial.TabIndex = 16;
            btnAddMaterial.Text = "Add material";
            btnAddMaterial.UseVisualStyleBackColor = false;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1455, 7);
            label4.Name = "label4";
            label4.Size = new Size(1, 25);
            label4.TabIndex = 84;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ButtonHighlight;
            lblName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(1462, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 83;
            lblName.Text = "label1";
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Left;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(390, 677);
            sideBar1.TabIndex = 85;
            // 
            // btnAddMat
            // 
            btnAddMat.BackColor = SystemColors.Window;
            btnAddMat.Cursor = Cursors.Hand;
            btnAddMat.Location = new Point(921, 150);
            btnAddMat.Name = "btnAddMat";
            btnAddMat.Size = new Size(135, 29);
            btnAddMat.TabIndex = 86;
            btnAddMat.Text = "Add material";
            btnAddMat.UseVisualStyleBackColor = false;
            btnAddMat.Click += btnAddMat_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(474, 67);
            label1.Name = "label1";
            label1.Size = new Size(179, 50);
            label1.TabIndex = 87;
            label1.Text = "Materials";
            // 
            // frmAllMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1146, 677);
            Controls.Add(label1);
            Controls.Add(btnAddMat);
            Controls.Add(sideBar1);
            Controls.Add(label4);
            Controls.Add(lblName);
            Controls.Add(btnAddMaterial);
            Controls.Add(groupBox1);
            Name = "frmAllMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAllMaterial_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvMaterial;
        private Button btnAddMaterial;
        private Label label4;
        private Label lblName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewButtonColumn btnDelete;
        private SideBar sideBar1;
        private Button btnAddMat;
        private Label label1;
    }
}