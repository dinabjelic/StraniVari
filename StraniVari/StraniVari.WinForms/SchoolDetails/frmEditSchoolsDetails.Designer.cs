namespace StraniVari.WinUI.SchoolDetails
{
    partial class frmEditSchoolsDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNumberofChildren = new Label();
            txtSchoolName = new TextBox();
            txtSchoolAddress = new TextBox();
            txtSchoolCity = new TextBox();
            txtNumberOfChildren = new TextBox();
            btnEditSchoolDetails = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 14;
            label1.Text = "School name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 15;
            label2.Text = "School address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 125);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 16;
            label3.Text = "School city";
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(24, 173);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(138, 20);
            lblNumberofChildren.TabIndex = 17;
            lblNumberofChildren.Text = "Number of children";
            // 
            // txtSchoolName
            // 
            txtSchoolName.Location = new Point(168, 36);
            txtSchoolName.Name = "txtSchoolName";
            txtSchoolName.ReadOnly = true;
            txtSchoolName.Size = new Size(247, 27);
            txtSchoolName.TabIndex = 18;
            // 
            // txtSchoolAddress
            // 
            txtSchoolAddress.Location = new Point(168, 84);
            txtSchoolAddress.Name = "txtSchoolAddress";
            txtSchoolAddress.ReadOnly = true;
            txtSchoolAddress.Size = new Size(247, 27);
            txtSchoolAddress.TabIndex = 19;
            // 
            // txtSchoolCity
            // 
            txtSchoolCity.Location = new Point(168, 125);
            txtSchoolCity.Name = "txtSchoolCity";
            txtSchoolCity.ReadOnly = true;
            txtSchoolCity.Size = new Size(247, 27);
            txtSchoolCity.TabIndex = 20;
            // 
            // txtNumberOfChildren
            // 
            txtNumberOfChildren.Cursor = Cursors.Hand;
            txtNumberOfChildren.ForeColor = SystemColors.InfoText;
            txtNumberOfChildren.Location = new Point(168, 173);
            txtNumberOfChildren.Name = "txtNumberOfChildren";
            txtNumberOfChildren.Size = new Size(247, 27);
            txtNumberOfChildren.TabIndex = 21;
            txtNumberOfChildren.Text = "numbers only";
            txtNumberOfChildren.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEditSchoolDetails
            // 
            btnEditSchoolDetails.BackColor = SystemColors.ButtonHighlight;
            btnEditSchoolDetails.Location = new Point(321, 215);
            btnEditSchoolDetails.Name = "btnEditSchoolDetails";
            btnEditSchoolDetails.Size = new Size(94, 29);
            btnEditSchoolDetails.TabIndex = 22;
            btnEditSchoolDetails.Text = "Save";
            btnEditSchoolDetails.UseVisualStyleBackColor = false;
            btnEditSchoolDetails.Click += btnEditSchoolDetails_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmEditSchoolsDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(447, 264);
            Controls.Add(btnEditSchoolDetails);
            Controls.Add(txtNumberOfChildren);
            Controls.Add(txtSchoolCity);
            Controls.Add(txtSchoolAddress);
            Controls.Add(txtSchoolName);
            Controls.Add(lblNumberofChildren);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditSchoolsDetails";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmEditSchoolsDetails_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNumberofChildren;
        private TextBox txtSchoolName;
        private TextBox txtSchoolAddress;
        private TextBox txtSchoolCity;
        private TextBox txtNumberOfChildren;
        private Button btnEditSchoolDetails;
        private ErrorProvider err;
    }
}