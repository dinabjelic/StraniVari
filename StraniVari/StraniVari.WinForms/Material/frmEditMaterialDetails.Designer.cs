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
            label4 = new Label();
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtTheme = new TextBox();
            txtName = new TextBox();
            txtSchool = new TextBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnEditSchoolDetails
            // 
            btnEditSchoolDetails.Location = new Point(1094, 423);
            btnEditSchoolDetails.Name = "btnEditSchoolDetails";
            btnEditSchoolDetails.Size = new Size(94, 29);
            btnEditSchoolDetails.TabIndex = 36;
            btnEditSchoolDetails.Text = "Save";
            btnEditSchoolDetails.UseVisualStyleBackColor = true;
            btnEditSchoolDetails.Click += btnEditSchoolDetails_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Cursor = Cursors.Hand;
            txtQuantity.ForeColor = SystemColors.InfoText;
            txtQuantity.Location = new Point(917, 370);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(271, 27);
            txtQuantity.TabIndex = 35;
            txtQuantity.Text = "numbers only";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaterailName
            // 
            txtMaterailName.Location = new Point(917, 306);
            txtMaterailName.Name = "txtMaterailName";
            txtMaterailName.ReadOnly = true;
            txtMaterailName.Size = new Size(271, 27);
            txtMaterailName.TabIndex = 32;
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(773, 370);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(65, 20);
            lblNumberofChildren.TabIndex = 31;
            lblNumberofChildren.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(773, 306);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 28;
            label1.Text = "Material name";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(752, 59);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 27;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(517, 339);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(217, 19);
            txtEndDate.TabIndex = 26;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(517, 386);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(217, 19);
            txtStartDate.TabIndex = 25;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(517, 294);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(217, 19);
            txtTheme.TabIndex = 24;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(517, 259);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(217, 19);
            txtName.TabIndex = 23;
            // 
            // txtSchool
            // 
            txtSchool.BorderStyle = BorderStyle.None;
            txtSchool.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchool.Location = new Point(517, 423);
            txtSchool.Name = "txtSchool";
            txtSchool.ReadOnly = true;
            txtSchool.Size = new Size(217, 19);
            txtSchool.TabIndex = 37;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmEditMaterialDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(txtSchool);
            Controls.Add(btnEditSchoolDetails);
            Controls.Add(txtQuantity);
            Controls.Add(txtMaterailName);
            Controls.Add(lblNumberofChildren);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtTheme);
            Controls.Add(txtName);
            Name = "frmEditMaterialDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditMaterialDetails";
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
        private Label label4;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtTheme;
        private TextBox txtName;
        private TextBox txtSchool;
        private ErrorProvider err;
    }
}