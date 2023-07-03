namespace StraniVari.WinUI.Material
{
    partial class frmEditMaterialDetails
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
            btnEditSchoolDetails = new Button();
            txtQuantity = new TextBox();
            txtMaterailName = new TextBox();
            lblNumberofChildren = new Label();
            label1 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnEditSchoolDetails
            // 
            btnEditSchoolDetails.BackColor = SystemColors.Window;
            btnEditSchoolDetails.Cursor = Cursors.Hand;
            btnEditSchoolDetails.Location = new Point(341, 150);
            btnEditSchoolDetails.Name = "btnEditSchoolDetails";
            btnEditSchoolDetails.Size = new Size(94, 29);
            btnEditSchoolDetails.TabIndex = 36;
            btnEditSchoolDetails.Text = "Save";
            btnEditSchoolDetails.UseVisualStyleBackColor = false;
            btnEditSchoolDetails.Click += btnEditSchoolDetails_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Cursor = Cursors.Hand;
            txtQuantity.ForeColor = SystemColors.InfoText;
            txtQuantity.Location = new Point(164, 97);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(271, 27);
            txtQuantity.TabIndex = 35;
            txtQuantity.Text = "numbers only";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaterailName
            // 
            txtMaterailName.Location = new Point(164, 33);
            txtMaterailName.Name = "txtMaterailName";
            txtMaterailName.ReadOnly = true;
            txtMaterailName.Size = new Size(271, 27);
            txtMaterailName.TabIndex = 32;
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(20, 97);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(65, 20);
            lblNumberofChildren.TabIndex = 31;
            lblNumberofChildren.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 28;
            label1.Text = "Material name";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmEditMaterialDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(466, 197);
            Controls.Add(btnEditSchoolDetails);
            Controls.Add(txtQuantity);
            Controls.Add(txtMaterailName);
            Controls.Add(lblNumberofChildren);
            Controls.Add(label1);
            Name = "frmEditMaterialDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmEditMaterialDetails_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditSchoolDetails;
        private TextBox txtQuantity;
        private TextBox txtMaterailName;
        private Label lblNumberofChildren;
        private Label label1;
        private ErrorProvider err;
    }
}