namespace StraniVari.WinUI.Volunteers
{
    partial class frmAddVolunteersToSchool
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
            label3 = new Label();
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtName = new TextBox();
            txtTheme = new TextBox();
            label1 = new Label();
            btnAddVolunteersToSchool = new Button();
            label2 = new Label();
            lbxVolunteers = new ListBox();
            label6 = new Label();
            label5 = new Label();
            btnView = new Button();
            SuspendLayout();
            // 
            // txtSchool
            // 
            txtSchool.BorderStyle = BorderStyle.None;
            txtSchool.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchool.Location = new Point(289, 423);
            txtSchool.Name = "txtSchool";
            txtSchool.ReadOnly = true;
            txtSchool.Size = new Size(248, 19);
            txtSchool.TabIndex = 35;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(553, 76);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuText;
            label3.Location = new Point(520, 315);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 33;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(289, 392);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(248, 19);
            txtEndDate.TabIndex = 32;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(289, 359);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(248, 19);
            txtStartDate.TabIndex = 30;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(289, 293);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(248, 19);
            txtName.TabIndex = 28;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(289, 326);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(248, 19);
            txtTheme.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 238);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 31;
            // 
            // btnAddVolunteersToSchool
            // 
            btnAddVolunteersToSchool.Cursor = Cursors.Hand;
            btnAddVolunteersToSchool.ForeColor = SystemColors.ActiveCaptionText;
            btnAddVolunteersToSchool.Location = new Point(1088, 535);
            btnAddVolunteersToSchool.Name = "btnAddVolunteersToSchool";
            btnAddVolunteersToSchool.Size = new Size(158, 29);
            btnAddVolunteersToSchool.TabIndex = 27;
            btnAddVolunteersToSchool.Text = "Add to school";
            btnAddVolunteersToSchool.UseVisualStyleBackColor = true;
            btnAddVolunteersToSchool.Click += btnAddVolunteersToSchool_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(581, 215);
            label2.Name = "label2";
            label2.Size = new Size(200, 20);
            label2.TabIndex = 26;
            label2.Text = "Choose volunteers for school";
            // 
            // lbxVolunteers
            // 
            lbxVolunteers.Cursor = Cursors.Hand;
            lbxVolunteers.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbxVolunteers.FormattingEnabled = true;
            lbxVolunteers.ItemHeight = 20;
            lbxVolunteers.Location = new Point(582, 248);
            lbxVolunteers.Name = "lbxVolunteers";
            lbxVolunteers.SelectionMode = SelectionMode.MultiSimple;
            lbxVolunteers.Size = new Size(664, 244);
            lbxVolunteers.TabIndex = 25;
            lbxVolunteers.SelectedIndexChanged += lbxVolunteers_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(1118, 215);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 37;
            label6.Text = "Selected items: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1230, 215);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 36;
            label5.Text = "0";
            // 
            // btnView
            // 
            btnView.Cursor = Cursors.Hand;
            btnView.ForeColor = SystemColors.ActiveCaptionText;
            btnView.Location = new Point(582, 525);
            btnView.Name = "btnView";
            btnView.Size = new Size(193, 29);
            btnView.TabIndex = 38;
            btnView.Text = "View added volunteers";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // frmAddVolunteersToSchool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(btnView);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSchool);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtName);
            Controls.Add(txtTheme);
            Controls.Add(label1);
            Controls.Add(btnAddVolunteersToSchool);
            Controls.Add(label2);
            Controls.Add(lbxVolunteers);
            Name = "frmAddVolunteersToSchool";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddVolunteersToSchool";
            Load += frmAddVolunteersToSchool_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSchool;
        private Label label4;
        private Label label3;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtName;
        private TextBox txtTheme;
        private Label label1;
        private Button btnAddVolunteersToSchool;
        private Label label2;
        private ListBox lbxVolunteers;
        private Label label6;
        private Label label5;
        private Button btnView;
    }
}