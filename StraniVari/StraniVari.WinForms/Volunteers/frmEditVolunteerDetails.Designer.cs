namespace StraniVari.WinUI.Volunteers
{
    partial class frmEditVolunteerDetails
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
            txtSchool = new TextBox();
            label4 = new Label();
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtTheme = new TextBox();
            txtName = new TextBox();
            btnEditVolunteerDetails = new Button();
            txtVolunteerCity = new TextBox();
            txtLastName = new TextBox();
            txtSFirstName = new TextBox();
            lblNumberofChildren = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtVolunteerAddress = new TextBox();
            cBTransportNeeded = new CheckBox();
            SuspendLayout();
            // 
            // txtSchool
            // 
            txtSchool.BorderStyle = BorderStyle.None;
            txtSchool.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchool.Location = new Point(416, 423);
            txtSchool.Name = "txtSchool";
            txtSchool.ReadOnly = true;
            txtSchool.Size = new Size(217, 19);
            txtSchool.TabIndex = 48;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(651, 78);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 42;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(416, 339);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(217, 19);
            txtEndDate.TabIndex = 41;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(416, 386);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(217, 19);
            txtStartDate.TabIndex = 40;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(416, 294);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(217, 19);
            txtTheme.TabIndex = 39;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(416, 259);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(217, 19);
            txtName.TabIndex = 38;
            // 
            // btnEditVolunteerDetails
            // 
            btnEditVolunteerDetails.Location = new Point(994, 471);
            btnEditVolunteerDetails.Name = "btnEditVolunteerDetails";
            btnEditVolunteerDetails.Size = new Size(94, 29);
            btnEditVolunteerDetails.TabIndex = 57;
            btnEditVolunteerDetails.Text = "Save";
            btnEditVolunteerDetails.UseVisualStyleBackColor = true;
            btnEditVolunteerDetails.Click += btnEditVolunteerDetails_Click;
            // 
            // txtVolunteerCity
            // 
            txtVolunteerCity.Location = new Point(819, 344);
            txtVolunteerCity.Name = "txtVolunteerCity";
            txtVolunteerCity.ReadOnly = true;
            txtVolunteerCity.Size = new Size(269, 27);
            txtVolunteerCity.TabIndex = 55;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(819, 303);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(269, 27);
            txtLastName.TabIndex = 54;
            // 
            // txtSFirstName
            // 
            txtSFirstName.Location = new Point(819, 255);
            txtSFirstName.Name = "txtSFirstName";
            txtSFirstName.ReadOnly = true;
            txtSFirstName.Size = new Size(269, 27);
            txtSFirstName.TabIndex = 53;
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(675, 392);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(62, 20);
            lblNumberofChildren.TabIndex = 52;
            lblNumberofChildren.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 344);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 51;
            label3.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(675, 303);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 50;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(675, 255);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 49;
            label1.Text = "First name";
            // 
            // txtVolunteerAddress
            // 
            txtVolunteerAddress.Location = new Point(819, 392);
            txtVolunteerAddress.Name = "txtVolunteerAddress";
            txtVolunteerAddress.ReadOnly = true;
            txtVolunteerAddress.Size = new Size(269, 27);
            txtVolunteerAddress.TabIndex = 58;
            // 
            // cBTransportNeeded
            // 
            cBTransportNeeded.AutoSize = true;
            cBTransportNeeded.Location = new Point(675, 439);
            cBTransportNeeded.Name = "cBTransportNeeded";
            cBTransportNeeded.Size = new Size(147, 24);
            cBTransportNeeded.TabIndex = 61;
            cBTransportNeeded.Text = "Transport needed";
            cBTransportNeeded.UseVisualStyleBackColor = true;
            // 
            // frmEditVolunteerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(cBTransportNeeded);
            Controls.Add(txtVolunteerAddress);
            Controls.Add(btnEditVolunteerDetails);
            Controls.Add(txtVolunteerCity);
            Controls.Add(txtLastName);
            Controls.Add(txtSFirstName);
            Controls.Add(lblNumberofChildren);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSchool);
            Controls.Add(label4);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtTheme);
            Controls.Add(txtName);
            Name = "frmEditVolunteerDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditVolunteerDetails";
            Load += frmEditVolunteerDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSchool;
        private Label label4;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtTheme;
        private TextBox txtName;
        private Button btnEditVolunteerDetails;
        private TextBox txtVolunteerCity;
        private TextBox txtLastName;
        private TextBox txtSFirstName;
        private Label lblNumberofChildren;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtVolunteerAddress;
        private CheckBox cBTransportNeeded;
    }
}