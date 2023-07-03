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
            // btnEditVolunteerDetails
            // 
            btnEditVolunteerDetails.BackColor = SystemColors.Window;
            btnEditVolunteerDetails.Cursor = Cursors.Hand;
            btnEditVolunteerDetails.Location = new Point(344, 257);
            btnEditVolunteerDetails.Name = "btnEditVolunteerDetails";
            btnEditVolunteerDetails.Size = new Size(94, 29);
            btnEditVolunteerDetails.TabIndex = 57;
            btnEditVolunteerDetails.Text = "Save";
            btnEditVolunteerDetails.UseVisualStyleBackColor = false;
            btnEditVolunteerDetails.Click += btnEditVolunteerDetails_Click;
            // 
            // txtVolunteerCity
            // 
            txtVolunteerCity.Location = new Point(169, 130);
            txtVolunteerCity.Name = "txtVolunteerCity";
            txtVolunteerCity.ReadOnly = true;
            txtVolunteerCity.Size = new Size(269, 27);
            txtVolunteerCity.TabIndex = 55;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(169, 89);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(269, 27);
            txtLastName.TabIndex = 54;
            // 
            // txtSFirstName
            // 
            txtSFirstName.Location = new Point(169, 41);
            txtSFirstName.Name = "txtSFirstName";
            txtSFirstName.ReadOnly = true;
            txtSFirstName.Size = new Size(269, 27);
            txtSFirstName.TabIndex = 53;
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(25, 178);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(62, 20);
            lblNumberofChildren.TabIndex = 52;
            lblNumberofChildren.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 130);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 51;
            label3.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 89);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 50;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 49;
            label1.Text = "First name";
            // 
            // txtVolunteerAddress
            // 
            txtVolunteerAddress.Location = new Point(169, 178);
            txtVolunteerAddress.Name = "txtVolunteerAddress";
            txtVolunteerAddress.ReadOnly = true;
            txtVolunteerAddress.Size = new Size(269, 27);
            txtVolunteerAddress.TabIndex = 58;
            // 
            // cBTransportNeeded
            // 
            cBTransportNeeded.AutoSize = true;
            cBTransportNeeded.Location = new Point(25, 225);
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
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(471, 313);
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
            Name = "frmEditVolunteerDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmEditVolunteerDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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