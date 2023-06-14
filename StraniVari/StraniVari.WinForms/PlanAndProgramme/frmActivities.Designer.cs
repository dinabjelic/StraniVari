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
            label3 = new Label();
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtTheme = new TextBox();
            txtName = new TextBox();
            rtbActivities = new RichTextBox();
            txtStartDatePP = new TextBox();
            label1 = new Label();
            txtEndDatePP = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(675, 77);
            label3.Name = "label3";
            label3.Size = new Size(1, 644);
            label3.TabIndex = 45;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(434, 394);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(225, 19);
            txtEndDate.TabIndex = 44;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(434, 441);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(225, 19);
            txtStartDate.TabIndex = 43;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(434, 349);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(217, 19);
            txtTheme.TabIndex = 42;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(434, 314);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(225, 19);
            txtName.TabIndex = 41;
            // 
            // rtbActivities
            // 
            rtbActivities.Location = new Point(694, 254);
            rtbActivities.Name = "rtbActivities";
            rtbActivities.ReadOnly = true;
            rtbActivities.Size = new Size(518, 289);
            rtbActivities.TabIndex = 46;
            rtbActivities.Text = "";
            // 
            // txtStartDatePP
            // 
            txtStartDatePP.BorderStyle = BorderStyle.None;
            txtStartDatePP.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDatePP.Location = new Point(857, 230);
            txtStartDatePP.Name = "txtStartDatePP";
            txtStartDatePP.ReadOnly = true;
            txtStartDatePP.Size = new Size(88, 18);
            txtStartDatePP.TabIndex = 50;
            txtStartDatePP.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(951, 230);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 51;
            label1.Text = "-";
            // 
            // txtEndDatePP
            // 
            txtEndDatePP.BorderStyle = BorderStyle.None;
            txtEndDatePP.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDatePP.Location = new Point(966, 230);
            txtEndDatePP.Name = "txtEndDatePP";
            txtEndDatePP.ReadOnly = true;
            txtEndDatePP.Size = new Size(88, 18);
            txtEndDatePP.TabIndex = 52;
            txtEndDatePP.TextAlign = HorizontalAlignment.Center;
            // 
            // frmActivities
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(txtEndDatePP);
            Controls.Add(label1);
            Controls.Add(txtStartDatePP);
            Controls.Add(rtbActivities);
            Controls.Add(label3);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtTheme);
            Controls.Add(txtName);
            Name = "frmActivities";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmActivities";
            Load += frmActivities_Load;
            ResumeLayout(false);
            PerformLayout();
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