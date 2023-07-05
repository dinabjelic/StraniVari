namespace StraniVari.WinUI.RecommendationSystem
{
    partial class frmRecommendationSystem
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
            rtbRecommend = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // rtbRecommend
            // 
            rtbRecommend.Location = new Point(12, 55);
            rtbRecommend.Name = "rtbRecommend";
            rtbRecommend.Size = new Size(535, 139);
            rtbRecommend.TabIndex = 0;
            rtbRecommend.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 17);
            label1.Name = "label1";
            label1.Size = new Size(395, 20);
            label1.TabIndex = 1;
            label1.Text = "We also recommend, if you did not get these materials yet";
            // 
            // frmRecommendationSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(571, 214);
            Controls.Add(label1);
            Controls.Add(rtbRecommend);
            Name = "frmRecommendationSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmRecommendationSystem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbRecommend;
        private Label label1;
    }
}