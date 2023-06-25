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
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Cursor = Cursors.Hand;
            txtAddress.ForeColor = SystemColors.InfoText;
            txtAddress.Location = new Point(159, 175);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(278, 27);
            txtAddress.TabIndex = 29;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(159, 127);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(278, 27);
            txtCity.TabIndex = 28;
            // 
            // txtMeetingPlace
            // 
            txtMeetingPlace.Location = new Point(159, 86);
            txtMeetingPlace.Name = "txtMeetingPlace";
            txtMeetingPlace.Size = new Size(278, 27);
            txtMeetingPlace.TabIndex = 27;
            // 
            // txtMeetingTheme
            // 
            txtMeetingTheme.Location = new Point(159, 38);
            txtMeetingTheme.Name = "txtMeetingTheme";
            txtMeetingTheme.Size = new Size(278, 27);
            txtMeetingTheme.TabIndex = 26;
            // 
            // lblNumberofChildren
            // 
            lblNumberofChildren.AutoSize = true;
            lblNumberofChildren.Location = new Point(15, 175);
            lblNumberofChildren.Name = "lblNumberofChildren";
            lblNumberofChildren.Size = new Size(62, 20);
            lblNumberofChildren.TabIndex = 25;
            lblNumberofChildren.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 127);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 24;
            label1.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 86);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 23;
            label2.Text = "Meeting place";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 38);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 22;
            label4.Text = "Meeting theme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 220);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 30;
            label5.Text = "Date";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Window;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(343, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(159, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 27);
            dateTimePicker1.TabIndex = 35;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmAddEditNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(460, 320);
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
            Load += frmAddEditNotification_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
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
    }
}