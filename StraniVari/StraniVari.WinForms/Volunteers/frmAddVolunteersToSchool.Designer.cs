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
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddVolunteersToSchool = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxVolunteers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSchool
            // 
            this.txtSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSchool.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSchool.Location = new System.Drawing.Point(47, 227);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.ReadOnly = true;
            this.txtSchool.Size = new System.Drawing.Size(248, 19);
            this.txtSchool.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(296, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 219);
            this.label4.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(306, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 33;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDate.Location = new System.Drawing.Point(47, 196);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(248, 19);
            this.txtEndDate.TabIndex = 32;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDate.Location = new System.Drawing.Point(47, 163);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(248, 19);
            this.txtStartDate.TabIndex = 30;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(47, 97);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(248, 19);
            this.txtName.TabIndex = 28;
            // 
            // txtTheme
            // 
            this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheme.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheme.Location = new System.Drawing.Point(47, 130);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(248, 19);
            this.txtTheme.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 31;
            // 
            // btnAddVolunteersToSchool
            // 
            this.btnAddVolunteersToSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVolunteersToSchool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddVolunteersToSchool.Location = new System.Drawing.Point(534, 268);
            this.btnAddVolunteersToSchool.Name = "btnAddVolunteersToSchool";
            this.btnAddVolunteersToSchool.Size = new System.Drawing.Size(158, 29);
            this.btnAddVolunteersToSchool.TabIndex = 27;
            this.btnAddVolunteersToSchool.Text = "Add to school";
            this.btnAddVolunteersToSchool.UseVisualStyleBackColor = true;
            this.btnAddVolunteersToSchool.Click += new System.EventHandler(this.btnAddVolunteersToSchool_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(343, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Choose volunteers for school";
            // 
            // lbxVolunteers
            // 
            this.lbxVolunteers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxVolunteers.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxVolunteers.FormattingEnabled = true;
            this.lbxVolunteers.ItemHeight = 20;
            this.lbxVolunteers.Location = new System.Drawing.Point(343, 110);
            this.lbxVolunteers.Name = "lbxVolunteers";
            this.lbxVolunteers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxVolunteers.Size = new System.Drawing.Size(349, 144);
            this.lbxVolunteers.TabIndex = 25;
            this.lbxVolunteers.SelectedIndexChanged += new System.EventHandler(this.lbxVolunteers_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(549, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Selected items: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(661, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "0";
            // 
            // frmAddVolunteersToSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 348);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddVolunteersToSchool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxVolunteers);
            this.Name = "frmAddVolunteersToSchool";
            this.Text = "frmAddVolunteersToSchool";
            this.Load += new System.EventHandler(this.frmAddVolunteersToSchool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}