﻿namespace StraniVari.WinUI.Material
{
    partial class SideBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBar));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            lblName = new Label();
            btnEvents = new Button();
            btnSchool = new Button();
            btnUser = new Button();
            btnMaterial = new Button();
            btnTrips = new Button();
            btnGames = new Button();
            btnReports = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            button3 = new Button();
            button4 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
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
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(388, 914);
            flowLayoutPanel1.TabIndex = 48;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lblName);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(385, 106);
            panel3.TabIndex = 93;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblName
            // 
            lblName.BackColor = SystemColors.GradientActiveCaption;
            lblName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(9, 77);
            lblName.Name = "lblName";
            lblName.Size = new Size(376, 17);
            lblName.TabIndex = 4;
            lblName.Text = "name.lastname@gmail.com";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEvents
            // 
            btnEvents.BackColor = SystemColors.GradientActiveCaption;
            btnEvents.Cursor = Cursors.Hand;
            btnEvents.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEvents.ForeColor = SystemColors.MenuText;
            btnEvents.Location = new Point(3, 115);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(385, 50);
            btnEvents.TabIndex = 88;
            btnEvents.Text = "Events";
            btnEvents.UseVisualStyleBackColor = false;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnSchool
            // 
            btnSchool.BackColor = SystemColors.GradientActiveCaption;
            btnSchool.Cursor = Cursors.Hand;
            btnSchool.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchool.ForeColor = SystemColors.WindowText;
            btnSchool.Location = new Point(3, 171);
            btnSchool.Name = "btnSchool";
            btnSchool.Size = new Size(385, 45);
            btnSchool.TabIndex = 89;
            btnSchool.Text = "Schools";
            btnSchool.UseVisualStyleBackColor = false;
            btnSchool.Click += btnSchool_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.GradientActiveCaption;
            btnUser.Cursor = Cursors.Hand;
            btnUser.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = SystemColors.WindowText;
            btnUser.Location = new Point(3, 222);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(385, 51);
            btnUser.TabIndex = 90;
            btnUser.Text = "Users";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnMaterial
            // 
            btnMaterial.BackColor = SystemColors.GradientActiveCaption;
            btnMaterial.Cursor = Cursors.Hand;
            btnMaterial.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaterial.ForeColor = SystemColors.WindowText;
            btnMaterial.Location = new Point(3, 279);
            btnMaterial.Name = "btnMaterial";
            btnMaterial.Size = new Size(385, 52);
            btnMaterial.TabIndex = 91;
            btnMaterial.Text = "Materials";
            btnMaterial.UseVisualStyleBackColor = false;
            btnMaterial.Click += btnMaterial_Click;
            // 
            // btnTrips
            // 
            btnTrips.BackColor = SystemColors.GradientActiveCaption;
            btnTrips.Cursor = Cursors.Hand;
            btnTrips.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrips.ForeColor = SystemColors.WindowText;
            btnTrips.Location = new Point(0, 334);
            btnTrips.Margin = new Padding(0);
            btnTrips.Name = "btnTrips";
            btnTrips.Size = new Size(388, 50);
            btnTrips.TabIndex = 92;
            btnTrips.Text = "Trips";
            btnTrips.UseVisualStyleBackColor = false;
            btnTrips.Click += btnTrips_Click;
            // 
            // btnGames
            // 
            btnGames.BackColor = SystemColors.GradientActiveCaption;
            btnGames.Cursor = Cursors.Hand;
            btnGames.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGames.ForeColor = SystemColors.WindowText;
            btnGames.Location = new Point(3, 387);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(385, 47);
            btnGames.TabIndex = 93;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            btnGames.Click += btnGames_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.GradientActiveCaption;
            btnReports.Cursor = Cursors.Hand;
            btnReports.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnReports.ForeColor = SystemColors.WindowText;
            btnReports.Location = new Point(3, 440);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(385, 54);
            btnReports.TabIndex = 94;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 31);
            panel1.TabIndex = 84;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 555);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 49);
            panel2.TabIndex = 95;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(45, 0);
            button1.Name = "button1";
            button1.Size = new Size(290, 46);
            button1.TabIndex = 94;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button4);
            panel4.Location = new Point(3, 537);
            panel4.Name = "panel4";
            panel4.Size = new Size(385, 49);
            panel4.TabIndex = 96;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(button3);
            panel5.Location = new Point(3, 555);
            panel5.Name = "panel5";
            panel5.Size = new Size(385, 49);
            panel5.TabIndex = 95;
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.WindowText;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(45, 0);
            button3.Name = "button3";
            button3.Size = new Size(290, 46);
            button3.TabIndex = 94;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LemonChiffon;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.IndianRed;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(139, 0);
            button4.Name = "button4";
            button4.Size = new Size(115, 46);
            button4.TabIndex = 94;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "SideBar";
            Size = new Size(389, 914);
            Load += SideBar_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label lblName;
        private Button btnEvents;
        private Button btnSchool;
        private Button btnUser;
        private Button btnMaterial;
        private Button btnTrips;
        private Button btnGames;
        private Button btnReports;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private Button button3;
        private Button button4;
    }
}
