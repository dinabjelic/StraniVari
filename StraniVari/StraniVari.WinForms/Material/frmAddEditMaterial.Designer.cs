namespace StraniVari.WinUI.Material
{
    partial class frmAddEditMaterial
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
            components = new System.ComponentModel.Container();
            btnSave = new Button();
            txtMaterialName = new TextBox();
            label1 = new Label();
            err = new ErrorProvider(components);
            label4 = new Label();
            lblName = new Label();
            sideBar1 = new SideBar();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(820, 356);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 38);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMaterialName
            // 
            txtMaterialName.Location = new Point(627, 311);
            txtMaterialName.Margin = new Padding(3, 4, 3, 4);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(268, 27);
            txtMaterialName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 314);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Material";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1460, 7);
            label4.Name = "label4";
            label4.Size = new Size(1, 25);
            label4.TabIndex = 86;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ButtonHighlight;
            lblName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(1467, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 85;
            lblName.Text = "label1";
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Left;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(391, 677);
            sideBar1.TabIndex = 87;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(475, 93);
            label2.Name = "label2";
            label2.Size = new Size(179, 50);
            label2.TabIndex = 88;
            label2.Text = "Materials";
            // 
            // frmAddEditMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1146, 677);
            Controls.Add(label2);
            Controls.Add(sideBar1);
            Controls.Add(label4);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            Controls.Add(txtMaterialName);
            Controls.Add(label1);
            Name = "frmAddEditMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMaterial";
            Load += frmAddEditMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox txtMaterialName;
        private Label label1;
        private ErrorProvider err;
        private Label label4;
        private Label lblName;
        private SideBar sideBar1;
        private Label label2;
    }
}