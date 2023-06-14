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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditMaterial));
            btnSave = new Button();
            txtMaterialName = new TextBox();
            label1 = new Label();
            err = new ErrorProvider(components);
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(1086, 354);
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
            txtMaterialName.Location = new Point(893, 309);
            txtMaterialName.Margin = new Padding(3, 4, 3, 4);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(268, 27);
            txtMaterialName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(817, 312);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Material";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(448, 198);
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
            label4.Location = new Point(767, 46);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 77;
            // 
            // frmAddEditMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(txtMaterialName);
            Controls.Add(label1);
            Name = "frmAddEditMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMaterial";
            Load += frmAddEditMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox txtMaterialName;
        private Label label1;
        private ErrorProvider err;
        private PictureBox pictureBox2;
        private Label label4;
    }
}