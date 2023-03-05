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
            this.rtbRecommend = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbRecommend
            // 
            this.rtbRecommend.Location = new System.Drawing.Point(48, 110);
            this.rtbRecommend.Name = "rtbRecommend";
            this.rtbRecommend.Size = new System.Drawing.Size(393, 139);
            this.rtbRecommend.TabIndex = 0;
            this.rtbRecommend.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "We also recommend, if you did not get these materials yet";
            // 
            // frmRecommendationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbRecommend);
            this.Name = "frmRecommendationSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecommendationSystem";
            this.Load += new System.EventHandler(this.frmRecommendationSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbRecommend;
        private Label label1;
    }
}