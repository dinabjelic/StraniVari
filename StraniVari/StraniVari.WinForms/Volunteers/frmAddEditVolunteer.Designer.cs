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
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtVolunteerAddress
            // 
            txtVolunteerAddress.Location = new Point(222, 194);
            txtVolunteerAddress.Name = "txtVolunteerAddress";
            txtVolunteerAddress.Size = new Size(250, 27);
            txtVolunteerAddress.TabIndex = 4;
            // 
            // btnEditVolunteerDetails
            // 
            btnEditVolunteerDetails.BackColor = Color.White;
            btnEditVolunteerDetails.Cursor = Cursors.Hand;
            btnEditVolunteerDetails.Location = new Point(378, 448);
            btnEditVolunteerDetails.Name = "btnEditVolunteerDetails";
            btnEditVolunteerDetails.Size = new Size(94, 29);
            btnEditVolunteerDetails.TabIndex = 9;
            btnEditVolunteerDetails.Text = "Save";
            btnEditVolunteerDetails.UseVisualStyleBackColor = false;
            btnEditVolunteerDetails.Click += btnEditVolunteerDetails_Click;
            // 
            // txtVolunteerCity
            // 
            txtVolunteerCity.Location = new Point(222, 146);
            txtVolunteerCity.Name = "txtVolunteerCity";
            txtVolunteerCity.Size = new Size(250, 27);
            txtVolunteerCity.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(222, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(222, 57);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(78, 194);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(62, 20);
            lblNumberofChildren.TabIndex = 66;
            lblNumberofChildren.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 146);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 65;
            label3.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 105);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 64;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 57);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 63;
            label1.Text = "First name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 245);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 74;
            label5.Text = "Date of birth";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(222, 240);
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
            label6.Location = new Point(78, 396);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 75;
            label6.Text = "Confirm password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 347);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 76;
            label7.Text = "Password";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(78, 304);
            label.Name = "label";
            label.Size = new Size(75, 20);
            label.TabIndex = 77;
            label.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(223, 301);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 27);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(222, 349);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(221, 397);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(251, 27);
            txtConfirmPassword.TabIndex = 8;
            // 
            // frmAddEditVolunteer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(580, 530);
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
            Load += frmAddEditVolunteer_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
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
    }
}