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
            rtbActivities = new RichTextBox();
            txtStartDatePP = new TextBox();
            label1 = new Label();
            txtEndDatePP = new TextBox();
            SuspendLayout();
            // 
            // rtbActivities
            // 
            rtbActivities.Location = new Point(12, 38);
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
            txtStartDatePP.Location = new Point(175, 14);
            txtStartDatePP.Name = "txtStartDatePP";
            txtStartDatePP.ReadOnly = true;
            txtStartDatePP.Size = new Size(88, 18);
            txtStartDatePP.TabIndex = 50;
            txtStartDatePP.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 14);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 51;
            label1.Text = "-";
            // 
            // txtEndDatePP
            // 
            txtEndDatePP.BorderStyle = BorderStyle.None;
            txtEndDatePP.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDatePP.Location = new Point(284, 14);
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
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(553, 340);
            Controls.Add(txtEndDatePP);
            Controls.Add(label1);
            Controls.Add(txtStartDatePP);
            Controls.Add(rtbActivities);
            Name = "frmActivities";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmActivities_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtbActivities;
        private TextBox txtStartDatePP;
        private Label label1;
        private TextBox txtEndDatePP;
    }
}