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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditVolunteer));
            txtVolunteerAddress = new TextBox();
            btnEditVolunteerDetails = new Button();
            txtVolunteerCity = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblNumberofChildren = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            dtpBirth = new DateTimePicker();
            err = new ErrorProvider(components);
            label6 = new Label();
            label7 = new Label();
            label = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtVolunteerAddress
            // 
            txtVolunteerAddress.Location = new Point(862, 309);
            txtVolunteerAddress.Name = "txtVolunteerAddress";
            txtVolunteerAddress.Size = new Size(250, 27);
            txtVolunteerAddress.TabIndex = 4;
            // 
            // btnEditVolunteerDetails
            // 
            btnEditVolunteerDetails.Cursor = Cursors.Hand;
            btnEditVolunteerDetails.Location = new Point(1018, 563);
            btnEditVolunteerDetails.Name = "btnEditVolunteerDetails";
            btnEditVolunteerDetails.Size = new Size(94, 29);
            btnEditVolunteerDetails.TabIndex = 6;
            btnEditVolunteerDetails.Text = "Save";
            btnEditVolunteerDetails.UseVisualStyleBackColor = true;
            btnEditVolunteerDetails.Click += btnEditVolunteerDetails_Click;
            // 
            // txtVolunteerCity
            // 
            txtVolunteerCity.Location = new Point(862, 261);
            txtVolunteerCity.Name = "txtVolunteerCity";
            txtVolunteerCity.Size = new Size(250, 27);
            txtVolunteerCity.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(862, 220);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(862, 172);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(718, 309);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(62, 20);
            lblNumberofChildren.TabIndex = 66;
            lblNumberofChildren.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(718, 261);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 65;
            label3.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(718, 220);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 64;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(718, 172);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 63;
            label1.Text = "First name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(718, 360);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 74;
            label5.Text = "Date of birth";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(862, 355);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(250, 27);
            dtpBirth.TabIndex = 5;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(718, 511);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 75;
            label6.Text = "Confirm password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(718, 462);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 76;
            label7.Text = "Password";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(718, 419);
            label.Name = "label";
            label.Size = new Size(75, 20);
            label.TabIndex = 77;
            label.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(863, 416);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 27);
            txtUsername.TabIndex = 78;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(862, 464);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 79;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(861, 512);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(251, 27);
            txtConfirmPassword.TabIndex = 80;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(328, 201);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 330);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 82;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(647, 49);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 81;
            // 
            // frmAddEditVolunteer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpBirth);
            Controls.Add(label5);
            Controls.Add(txtVolunteerAddress);
            Controls.Add(btnEditVolunteerDetails);
            Controls.Add(txtVolunteerCity);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblNumberofChildren);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddEditVolunteer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditVolunteer";
            Load += frmAddEditVolunteer_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label5;
        private DateTimePicker dtpBirth;
        private ErrorProvider err;
        private Label label;
        private Label label7;
        private Label label6;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private Label label4;
    }
}