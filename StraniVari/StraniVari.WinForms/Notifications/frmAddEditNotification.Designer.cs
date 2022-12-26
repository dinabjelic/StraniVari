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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditNotification));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtMeetingPlace = new System.Windows.Forms.TextBox();
            this.txtMeetingTheme = new System.Windows.Forms.TextBox();
            this.lblNumberofChildren = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(174, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 335);
            this.label3.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAddress.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddress.Location = new System.Drawing.Point(343, 232);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 27);
            this.txtAddress.TabIndex = 29;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(343, 184);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(250, 27);
            this.txtCity.TabIndex = 28;
            // 
            // txtMeetingPlace
            // 
            this.txtMeetingPlace.Location = new System.Drawing.Point(343, 143);
            this.txtMeetingPlace.Name = "txtMeetingPlace";
            this.txtMeetingPlace.Size = new System.Drawing.Size(250, 27);
            this.txtMeetingPlace.TabIndex = 27;
            // 
            // txtMeetingTheme
            // 
            this.txtMeetingTheme.Location = new System.Drawing.Point(343, 95);
            this.txtMeetingTheme.Name = "txtMeetingTheme";
            this.txtMeetingTheme.Size = new System.Drawing.Size(250, 27);
            this.txtMeetingTheme.TabIndex = 26;
            // 
            // lblNumberofChildren
            // 
            this.lblNumberofChildren.AutoSize = true;
            this.lblNumberofChildren.Location = new System.Drawing.Point(199, 232);
            this.lblNumberofChildren.Name = "lblNumberofChildren";
            this.lblNumberofChildren.Size = new System.Drawing.Size(62, 20);
            this.lblNumberofChildren.TabIndex = 25;
            this.lblNumberofChildren.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Meeting place";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Meeting theme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Date";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(499, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(343, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // frmAddEditNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 410);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtMeetingPlace);
            this.Controls.Add(this.txtMeetingTheme);
            this.Controls.Add(this.lblNumberofChildren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAddEditNotification";
            this.Text = "frmAddEditNotification";
            this.Load += new System.EventHandler(this.frmAddEditNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private PictureBox pictureBox1;
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
    }
}