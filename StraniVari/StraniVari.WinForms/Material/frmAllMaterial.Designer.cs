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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllMaterial));
            groupBox1 = new GroupBox();
            dgvMaterial = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            MaterialName = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnAddMaterial = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMaterial);
            groupBox1.Location = new Point(624, 179);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(663, 366);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "MATERIAL";
            // 
            // dgvMaterial
            // 
            dgvMaterial.AllowUserToAddRows = false;
            dgvMaterial.AllowUserToDeleteRows = false;
            dgvMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterial.Columns.AddRange(new DataGridViewColumn[] { Id, MaterialName, btnEdit, btnDelete });
            dgvMaterial.Cursor = Cursors.Hand;
            dgvMaterial.Dock = DockStyle.Fill;
            dgvMaterial.Location = new Point(3, 24);
            dgvMaterial.Margin = new Padding(3, 4, 3, 4);
            dgvMaterial.Name = "dgvMaterial";
            dgvMaterial.ReadOnly = true;
            dgvMaterial.RowHeadersWidth = 51;
            dgvMaterial.RowTemplate.Height = 24;
            dgvMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterial.Size = new Size(657, 338);
            dgvMaterial.TabIndex = 0;
            dgvMaterial.CellContentClick += dgvMaterial_CellContentClick;
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
            // btnAddMaterial
            // 
            btnAddMaterial.Cursor = Cursors.Hand;
            btnAddMaterial.Location = new Point(1149, 156);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(135, 29);
            btnAddMaterial.TabIndex = 16;
            btnAddMaterial.Text = "Add material";
            btnAddMaterial.UseVisualStyleBackColor = true;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(251, 203);
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
            label4.Location = new Point(570, 51);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 77;
            // 
            // frmAllMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(btnAddMaterial);
            Controls.Add(groupBox1);
            Name = "frmAllMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllMaterial";
            Load += frmAllMaterial_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvMaterial;
        private Button btnAddMaterial;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
        private PictureBox pictureBox2;
        private Label label4;
    }
}