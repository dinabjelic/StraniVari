﻿namespace StraniVari.WinUI.Trip
{
    partial class frmAddEditTrip
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
            err = new ErrorProvider(components);
            label1 = new Label();
            txtPlace = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnTrip = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            btnEvents = new Button();
            btnSchool = new Button();
            btnUser = new Button();
            btnMaterial = new Button();
            btnTrips = new Button();
            btnGames = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            label4 = new Label();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(722, 231);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 16;
            label1.Text = "Place";
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(823, 231);
            txtPlace.Margin = new Padding(2);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(285, 27);
            txtPlace.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(722, 298);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 18;
            label2.Text = "Date Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(823, 291);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(285, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // btnTrip
            // 
            btnTrip.Cursor = Cursors.Hand;
            btnTrip.Location = new Point(1018, 399);
            btnTrip.Margin = new Padding(2);
            btnTrip.Name = "btnTrip";
            btnTrip.Size = new Size(90, 27);
            btnTrip.TabIndex = 20;
            btnTrip.Text = "Save";
            btnTrip.UseVisualStyleBackColor = true;
            btnTrip.Click += btnTrip_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(823, 347);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 28);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(722, 355);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 79;
            label3.Text = "Event";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(btnEvents);
            flowLayoutPanel1.Controls.Add(btnSchool);
            flowLayoutPanel1.Controls.Add(btnUser);
            flowLayoutPanel1.Controls.Add(btnMaterial);
            flowLayoutPanel1.Controls.Add(btnTrips);
            flowLayoutPanel1.Controls.Add(btnGames);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Controls.Add(btnLogout);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(389, 731);
            flowLayoutPanel1.TabIndex = 80;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 63);
            panel3.TabIndex = 93;
            // 
            // btnEvents
            // 
            btnEvents.BackColor = SystemColors.GradientActiveCaption;
            btnEvents.Cursor = Cursors.Hand;
            btnEvents.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEvents.ForeColor = SystemColors.MenuText;
            btnEvents.Location = new Point(3, 72);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(386, 57);
            btnEvents.TabIndex = 88;
            btnEvents.Text = "Events";
            btnEvents.UseVisualStyleBackColor = false;
            // 
            // btnSchool
            // 
            btnSchool.BackColor = SystemColors.GradientActiveCaption;
            btnSchool.Cursor = Cursors.Hand;
            btnSchool.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchool.ForeColor = SystemColors.WindowText;
            btnSchool.Location = new Point(3, 135);
            btnSchool.Name = "btnSchool";
            btnSchool.Size = new Size(386, 55);
            btnSchool.TabIndex = 84;
            btnSchool.Text = "Schools";
            btnSchool.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.GradientActiveCaption;
            btnUser.Cursor = Cursors.Hand;
            btnUser.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = SystemColors.WindowText;
            btnUser.Location = new Point(3, 196);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(386, 53);
            btnUser.TabIndex = 85;
            btnUser.Text = "Users";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnMaterial
            // 
            btnMaterial.BackColor = SystemColors.GradientActiveCaption;
            btnMaterial.Cursor = Cursors.Hand;
            btnMaterial.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaterial.ForeColor = SystemColors.WindowText;
            btnMaterial.Location = new Point(3, 255);
            btnMaterial.Name = "btnMaterial";
            btnMaterial.Size = new Size(386, 48);
            btnMaterial.TabIndex = 87;
            btnMaterial.Text = "Materials";
            btnMaterial.UseVisualStyleBackColor = false;
            // 
            // btnTrips
            // 
            btnTrips.BackColor = SystemColors.GradientActiveCaption;
            btnTrips.Cursor = Cursors.Hand;
            btnTrips.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrips.ForeColor = SystemColors.WindowText;
            btnTrips.Location = new Point(0, 306);
            btnTrips.Margin = new Padding(0);
            btnTrips.Name = "btnTrips";
            btnTrips.Size = new Size(389, 58);
            btnTrips.TabIndex = 91;
            btnTrips.Text = "Trips";
            btnTrips.UseVisualStyleBackColor = false;
            // 
            // btnGames
            // 
            btnGames.BackColor = SystemColors.GradientActiveCaption;
            btnGames.Cursor = Cursors.Hand;
            btnGames.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGames.ForeColor = SystemColors.WindowText;
            btnGames.Location = new Point(3, 367);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(386, 56);
            btnGames.TabIndex = 86;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.GradientActiveCaption;
            btnReports.Cursor = Cursors.Hand;
            btnReports.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = SystemColors.WindowText;
            btnReports.Location = new Point(3, 429);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(386, 58);
            btnReports.TabIndex = 89;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.GradientActiveCaption;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(3, 493);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(386, 38);
            btnLogout.TabIndex = 94;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1459, 7);
            label4.Name = "label4";
            label4.Size = new Size(1, 25);
            label4.TabIndex = 82;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ButtonHighlight;
            lblName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(1466, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 81;
            lblName.Text = "label1";
            // 
            // frmAddEditTrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1638, 731);
            Controls.Add(label4);
            Controls.Add(lblName);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(btnTrip);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtPlace);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmAddEditTrip";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEditTrip_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider err;
        private TextBox txtPlace;
        private Label label1;
        private Button btnTrip;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Button btnEvents;
        private Button btnSchool;
        private Button btnUser;
        private Button btnMaterial;
        private Button btnTrips;
        private Button btnGames;
        private Button btnReports;
        private Button btnLogout;
        private Label label4;
        private Label lblName;
    }
}