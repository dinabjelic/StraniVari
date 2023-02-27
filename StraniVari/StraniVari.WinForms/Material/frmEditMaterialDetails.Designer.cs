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
            this.components = new System.ComponentModel.Container();
            this.btnEditSchoolDetails = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtMaterailName = new System.Windows.Forms.TextBox();
            this.lblNumberofChildren = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditSchoolDetails
            // 
            this.btnEditSchoolDetails.Location = new System.Drawing.Point(538, 251);
            this.btnEditSchoolDetails.Name = "btnEditSchoolDetails";
            this.btnEditSchoolDetails.Size = new System.Drawing.Size(94, 29);
            this.btnEditSchoolDetails.TabIndex = 36;
            this.btnEditSchoolDetails.Text = "Save";
            this.btnEditSchoolDetails.UseVisualStyleBackColor = true;
            this.btnEditSchoolDetails.Click += new System.EventHandler(this.btnEditSchoolDetails_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtQuantity.Location = new System.Drawing.Point(435, 192);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(197, 27);
            this.txtQuantity.TabIndex = 35;
            this.txtQuantity.Text = "numbers only";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaterailName
            // 
            this.txtMaterailName.Location = new System.Drawing.Point(435, 128);
            this.txtMaterailName.Name = "txtMaterailName";
            this.txtMaterailName.ReadOnly = true;
            this.txtMaterailName.Size = new System.Drawing.Size(197, 27);
            this.txtMaterailName.TabIndex = 32;
            // 
            // lblNumberofChildren
            // 
            this.lblNumberofChildren.AutoSize = true;
            this.lblNumberofChildren.Location = new System.Drawing.Point(291, 192);
            this.lblNumberofChildren.Name = "lblNumberofChildren";
            this.lblNumberofChildren.Size = new System.Drawing.Size(65, 20);
            this.lblNumberofChildren.TabIndex = 31;
            this.lblNumberofChildren.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Material name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(272, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 282);
            this.label4.TabIndex = 27;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDate.Location = new System.Drawing.Point(36, 177);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(217, 19);
            this.txtEndDate.TabIndex = 26;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDate.Location = new System.Drawing.Point(36, 224);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(217, 19);
            this.txtStartDate.TabIndex = 25;
            // 
            // txtTheme
            // 
            this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheme.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheme.Location = new System.Drawing.Point(36, 132);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(217, 19);
            this.txtTheme.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(36, 97);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(217, 19);
            this.txtName.TabIndex = 23;
            // 
            // txtSchool
            // 
            this.txtSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSchool.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSchool.Location = new System.Drawing.Point(36, 261);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.ReadOnly = true;
            this.txtSchool.Size = new System.Drawing.Size(217, 19);
            this.txtSchool.TabIndex = 37;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmEditMaterialDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 371);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.btnEditSchoolDetails);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtMaterailName);
            this.Controls.Add(this.lblNumberofChildren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtName);
            this.Name = "frmEditMaterialDetails";
            this.Text = "frmEditMaterialDetails";
            this.Load += new System.EventHandler(this.frmEditMaterialDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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