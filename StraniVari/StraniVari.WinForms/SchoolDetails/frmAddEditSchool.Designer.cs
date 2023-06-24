namespace StraniVari.WinUI.SchoolDetails
{
    partial class frmAddEditSchool
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
            txtSchoolCity = new TextBox();
            txtSchoolAddress = new TextBox();
            txtSchoolName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnEditSchoolDetails
            // 
            btnEditSchoolDetails.BackColor = SystemColors.Window;
            btnEditSchoolDetails.Cursor = Cursors.Hand;
            btnEditSchoolDetails.Location = new Point(372, 186);
            btnEditSchoolDetails.Name = "btnEditSchoolDetails";
            btnEditSchoolDetails.Size = new Size(94, 29);
            btnEditSchoolDetails.TabIndex = 32;
            btnEditSchoolDetails.Text = "Save";
            btnEditSchoolDetails.UseVisualStyleBackColor = false;
            btnEditSchoolDetails.Click += btnEditSchoolDetails_Click;
            // 
            // txtSchoolCity
            // 
            txtSchoolCity.Location = new Point(170, 140);
            txtSchoolCity.Name = "txtSchoolCity";
            txtSchoolCity.Size = new Size(296, 27);
            txtSchoolCity.TabIndex = 30;
            // 
            // txtSchoolAddress
            // 
            txtSchoolAddress.Location = new Point(170, 99);
            txtSchoolAddress.Name = "txtSchoolAddress";
            txtSchoolAddress.Size = new Size(296, 27);
            txtSchoolAddress.TabIndex = 29;
            // 
            // txtSchoolName
            // 
            txtSchoolName.Location = new Point(170, 51);
            txtSchoolName.Name = "txtSchoolName";
            txtSchoolName.Size = new Size(296, 27);
            txtSchoolName.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 140);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 26;
            label3.Text = "School city";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 99);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 25;
            label2.Text = "School address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 51);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 24;
            label1.Text = "School name";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmAddEditSchool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(519, 278);
            Controls.Add(btnEditSchoolDetails);
            Controls.Add(txtSchoolCity);
            Controls.Add(txtSchoolAddress);
            Controls.Add(txtSchoolName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddEditSchool";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEditSchool_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditSchoolDetails;
        private TextBox txtSchoolCity;
        private TextBox txtSchoolAddress;
        private TextBox txtSchoolName;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider err;
    }
}