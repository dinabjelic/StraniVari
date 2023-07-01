namespace StraniVari.WinUI.Admin
{
    partial class frmAddEditAdminstrator
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
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label = new Label();
            label7 = new Label();
            label6 = new Label();
            dtpBirth = new DateTimePicker();
            label5 = new Label();
            txtVolunteerAddress = new TextBox();
            btnEditAdministratorDetails = new Button();
            txtVolunteerCity = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblNumberofChildren = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(227, 398);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(251, 27);
            txtConfirmPassword.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(228, 350);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(229, 302);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 27);
            txtUsername.TabIndex = 6;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(84, 305);
            label.Name = "label";
            label.Size = new Size(75, 20);
            label.TabIndex = 94;
            label.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 348);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 93;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 397);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 92;
            label6.Text = "Confirm password";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(228, 241);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(250, 27);
            dtpBirth.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 246);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 91;
            label5.Text = "Date of birth";
            // 
            // txtVolunteerAddress
            // 
            txtVolunteerAddress.Location = new Point(228, 195);
            txtVolunteerAddress.Name = "txtVolunteerAddress";
            txtVolunteerAddress.Size = new Size(250, 27);
            txtVolunteerAddress.TabIndex = 4;
            // 
            // btnEditAdministratorDetails
            // 
            btnEditAdministratorDetails.BackColor = Color.White;
            btnEditAdministratorDetails.Cursor = Cursors.Hand;
            btnEditAdministratorDetails.Location = new Point(384, 449);
            btnEditAdministratorDetails.Name = "btnEditAdministratorDetails";
            btnEditAdministratorDetails.Size = new Size(94, 29);
            btnEditAdministratorDetails.TabIndex = 9;
            btnEditAdministratorDetails.Text = "Save";
            btnEditAdministratorDetails.UseVisualStyleBackColor = false;
            btnEditAdministratorDetails.Click += btnEditAdministratorDetails_Click;
            // 
            // txtVolunteerCity
            // 
            txtVolunteerCity.Location = new Point(228, 147);
            txtVolunteerCity.Name = "txtVolunteerCity";
            txtVolunteerCity.Size = new Size(250, 27);
            txtVolunteerCity.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(228, 106);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(228, 58);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(84, 195);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(62, 20);
            lblNumberofChildren.TabIndex = 90;
            lblNumberofChildren.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 147);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 89;
            label3.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 106);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 88;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 58);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 87;
            label1.Text = "First name";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmAddEditAdminstrator
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
            Controls.Add(btnEditAdministratorDetails);
            Controls.Add(txtVolunteerCity);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblNumberofChildren);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddEditAdminstrator";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEditAdminstrator_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpBirth;
        private Label label5;
        private TextBox txtVolunteerAddress;
        private Button btnEditAdministratorDetails;
        private TextBox txtVolunteerCity;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblNumberofChildren;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider err;
    }
}