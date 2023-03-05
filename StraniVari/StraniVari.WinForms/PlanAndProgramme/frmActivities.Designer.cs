namespace StraniVari.WinUI.PlanAndProgramme
{
    partial class frmActivities
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtbActivities = new System.Windows.Forms.RichTextBox();
            this.txtStartDatePP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndDatePP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(271, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 386);
            this.label3.TabIndex = 45;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDate.Location = new System.Drawing.Point(27, 190);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(225, 19);
            this.txtEndDate.TabIndex = 44;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDate.Location = new System.Drawing.Point(27, 237);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(225, 19);
            this.txtStartDate.TabIndex = 43;
            // 
            // txtTheme
            // 
            this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheme.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheme.Location = new System.Drawing.Point(27, 145);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(217, 19);
            this.txtTheme.TabIndex = 42;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(27, 110);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(225, 19);
            this.txtName.TabIndex = 41;
            // 
            // rtbActivities
            // 
            this.rtbActivities.Location = new System.Drawing.Point(289, 93);
            this.rtbActivities.Name = "rtbActivities";
            this.rtbActivities.ReadOnly = true;
            this.rtbActivities.Size = new System.Drawing.Size(424, 269);
            this.rtbActivities.TabIndex = 46;
            this.rtbActivities.Text = "";
            // 
            // txtStartDatePP
            // 
            this.txtStartDatePP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDatePP.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDatePP.Location = new System.Drawing.Point(410, 69);
            this.txtStartDatePP.Name = "txtStartDatePP";
            this.txtStartDatePP.ReadOnly = true;
            this.txtStartDatePP.Size = new System.Drawing.Size(88, 18);
            this.txtStartDatePP.TabIndex = 50;
            this.txtStartDatePP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "-";
            // 
            // txtEndDatePP
            // 
            this.txtEndDatePP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDatePP.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDatePP.Location = new System.Drawing.Point(519, 69);
            this.txtEndDatePP.Name = "txtEndDatePP";
            this.txtEndDatePP.ReadOnly = true;
            this.txtEndDatePP.Size = new System.Drawing.Size(88, 18);
            this.txtEndDatePP.TabIndex = 52;
            this.txtEndDatePP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 442);
            this.Controls.Add(this.txtEndDatePP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartDatePP);
            this.Controls.Add(this.rtbActivities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtName);
            this.Name = "frmActivities";
            this.Text = "frmActivities";
            this.Load += new System.EventHandler(this.frmActivities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtTheme;
        private TextBox txtName;
        private RichTextBox rtbActivities;
        private TextBox txtStartDatePP;
        private Label label1;
        private TextBox txtEndDatePP;
    }
}