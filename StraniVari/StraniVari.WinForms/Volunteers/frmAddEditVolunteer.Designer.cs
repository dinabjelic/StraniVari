namespace StraniVari.WinUI.Volunteers
{
    partial class frmAddEditVolunteer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditVolunteer));
            this.txtVolunteerAddress = new System.Windows.Forms.TextBox();
            this.btnEditVolunteerDetails = new System.Windows.Forms.Button();
            this.txtVolunteerCity = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblNumberofChildren = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVolunteerAddress
            // 
            this.txtVolunteerAddress.Location = new System.Drawing.Point(391, 227);
            this.txtVolunteerAddress.Name = "txtVolunteerAddress";
            this.txtVolunteerAddress.Size = new System.Drawing.Size(250, 27);
            this.txtVolunteerAddress.TabIndex = 4;
            // 
            // btnEditVolunteerDetails
            // 
            this.btnEditVolunteerDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditVolunteerDetails.Location = new System.Drawing.Point(547, 481);
            this.btnEditVolunteerDetails.Name = "btnEditVolunteerDetails";
            this.btnEditVolunteerDetails.Size = new System.Drawing.Size(94, 29);
            this.btnEditVolunteerDetails.TabIndex = 6;
            this.btnEditVolunteerDetails.Text = "Save";
            this.btnEditVolunteerDetails.UseVisualStyleBackColor = true;
            this.btnEditVolunteerDetails.Click += new System.EventHandler(this.btnEditVolunteerDetails_Click);
            // 
            // txtVolunteerCity
            // 
            this.txtVolunteerCity.Location = new System.Drawing.Point(391, 179);
            this.txtVolunteerCity.Name = "txtVolunteerCity";
            this.txtVolunteerCity.Size = new System.Drawing.Size(250, 27);
            this.txtVolunteerCity.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(391, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 27);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(391, 90);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblNumberofChildren
            // 
            this.lblNumberofChildren.AutoSize = true;
            this.lblNumberofChildren.Location = new System.Drawing.Point(247, 227);
            this.lblNumberofChildren.Name = "lblNumberofChildren";
            this.lblNumberofChildren.Size = new System.Drawing.Size(62, 20);
            this.lblNumberofChildren.TabIndex = 66;
            this.lblNumberofChildren.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "First name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(213, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 438);
            this.label4.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Date of birth";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(391, 273);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(250, 27);
            this.dtpBirth.TabIndex = 5;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "Confirm password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 76;
            this.label7.Text = "Password";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(247, 337);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 20);
            this.label.TabIndex = 77;
            this.label.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(392, 334);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 27);
            this.txtUsername.TabIndex = 78;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(391, 382);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 27);
            this.txtPassword.TabIndex = 79;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(390, 430);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(251, 27);
            this.txtConfirmPassword.TabIndex = 80;
            // 
            // frmAddEditVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 544);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtVolunteerAddress);
            this.Controls.Add(this.btnEditVolunteerDetails);
            this.Controls.Add(this.txtVolunteerCity);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblNumberofChildren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmAddEditVolunteer";
            this.Text = "frmAddEditVolunteer";
            this.Load += new System.EventHandler(this.frmAddEditVolunteer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtVolunteerAddress;
        private Button btnEditVolunteerDetails;
        private TextBox txtVolunteerCity;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblNumberofChildren;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private DateTimePicker dtpBirth;
        private ErrorProvider err;
        private Label label;
        private Label label7;
        private Label label6;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
    }
}