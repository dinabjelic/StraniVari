namespace StraniVari.WinUI.Notifications
{
    partial class frmAddEditNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditNotification));
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtMeetingPlace = new TextBox();
            txtMeetingTheme = new TextBox();
            lblNumberofChildren = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            err = new ErrorProvider(components);
            pictureBox2 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Cursor = Cursors.Hand;
            txtAddress.ForeColor = SystemColors.InfoText;
            txtAddress.Location = new Point(907, 387);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(278, 27);
            txtAddress.TabIndex = 29;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(907, 339);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(278, 27);
            txtCity.TabIndex = 28;
            // 
            // txtMeetingPlace
            // 
            txtMeetingPlace.Location = new Point(907, 298);
            txtMeetingPlace.Name = "txtMeetingPlace";
            txtMeetingPlace.Size = new Size(278, 27);
            txtMeetingPlace.TabIndex = 27;
            // 
            // txtMeetingTheme
            // 
            txtMeetingTheme.Location = new Point(907, 250);
            txtMeetingTheme.Name = "txtMeetingTheme";
            txtMeetingTheme.Size = new Size(278, 27);
            txtMeetingTheme.TabIndex = 26;
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(763, 387);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(62, 20);
            lblNumberofChildren.TabIndex = 25;
            lblNumberofChildren.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(763, 339);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 24;
            label1.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(763, 298);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 23;
            label2.Text = "Meeting place";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(763, 250);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 22;
            label4.Text = "Meeting theme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(763, 432);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 30;
            label5.Text = "Date";
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(1091, 474);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(907, 432);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 27);
            dateTimePicker1.TabIndex = 35;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(365, 223);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 330);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(684, 71);
            label3.Name = "label3";
            label3.Size = new Size(1, 644);
            label3.TabIndex = 77;
            // 
            // frmAddEditNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(txtMeetingPlace);
            Controls.Add(txtMeetingTheme);
            Controls.Add(lblNumberofChildren);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Name = "frmAddEditNotification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditNotification";
            Load += frmAddEditNotification_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtMeetingPlace;
        private TextBox txtMeetingTheme;
        private Label lblNumberofChildren;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private ErrorProvider err;
        private PictureBox pictureBox2;
        private Label label3;
    }
}