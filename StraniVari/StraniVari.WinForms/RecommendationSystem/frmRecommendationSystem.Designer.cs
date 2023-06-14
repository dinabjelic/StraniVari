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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecommendationSystem));
            rtbRecommend = new RichTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rtbRecommend
            // 
            rtbRecommend.Location = new Point(706, 309);
            rtbRecommend.Name = "rtbRecommend";
            rtbRecommend.Size = new Size(535, 139);
            rtbRecommend.TabIndex = 0;
            rtbRecommend.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(769, 271);
            label1.Name = "label1";
            label1.Size = new Size(395, 20);
            label1.TabIndex = 1;
            label1.Text = "We also recommend, if you did not get these materials yet";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(368, 203);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 75;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(667, 176);
            label4.Name = "label4";
            label4.Size = new Size(1, 438);
            label4.TabIndex = 74;
            // 
            // frmRecommendationSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(rtbRecommend);
            Name = "frmRecommendationSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRecommendationSystem";
            Load += frmRecommendationSystem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbRecommend;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}