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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditSchool));
            this.btnEditSchoolDetails = new System.Windows.Forms.Button();
            this.txtSchoolCity = new System.Windows.Forms.TextBox();
            this.txtSchoolAddress = new System.Windows.Forms.TextBox();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditSchoolDetails
            // 
            this.btnEditSchoolDetails.Location = new System.Drawing.Point(477, 230);
            this.btnEditSchoolDetails.Name = "btnEditSchoolDetails";
            this.btnEditSchoolDetails.Size = new System.Drawing.Size(94, 29);
            this.btnEditSchoolDetails.TabIndex = 32;
            this.btnEditSchoolDetails.Text = "Save";
            this.btnEditSchoolDetails.UseVisualStyleBackColor = true;
            this.btnEditSchoolDetails.Click += new System.EventHandler(this.btnEditSchoolDetails_Click);
            // 
            // txtSchoolCity
            // 
            this.txtSchoolCity.Location = new System.Drawing.Point(374, 176);
            this.txtSchoolCity.Name = "txtSchoolCity";
            this.txtSchoolCity.Size = new System.Drawing.Size(197, 27);
            this.txtSchoolCity.TabIndex = 30;
            // 
            // txtSchoolAddress
            // 
            this.txtSchoolAddress.Location = new System.Drawing.Point(374, 135);
            this.txtSchoolAddress.Name = "txtSchoolAddress";
            this.txtSchoolAddress.Size = new System.Drawing.Size(197, 27);
            this.txtSchoolAddress.TabIndex = 29;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(374, 87);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(197, 27);
            this.txtSchoolName.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "School city";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "School address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "School name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(194, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 247);
            this.label4.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddEditSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEditSchoolDetails);
            this.Controls.Add(this.txtSchoolCity);
            this.Controls.Add(this.txtSchoolAddress);
            this.Controls.Add(this.txtSchoolName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmAddEditSchool";
            this.Text = "frmAddEditSchool";
            this.Load += new System.EventHandler(this.frmAddEditSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditSchoolDetails;
        private TextBox txtSchoolCity;
        private TextBox txtSchoolAddress;
        private TextBox txtSchoolName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox1;
    }
}