namespace StraniVari.WinUI.Games
{
    partial class frmGameDetails
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
            rtbRules = new RichTextBox();
            label2 = new Label();
            txtGameName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // rtbRules
            // 
            rtbRules.Location = new Point(111, 126);
            rtbRules.Name = "rtbRules";
            rtbRules.ReadOnly = true;
            rtbRules.Size = new Size(659, 217);
            rtbRules.TabIndex = 22;
            rtbRules.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 209);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 24;
            label2.Text = "Rules";
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(111, 64);
            txtGameName.Margin = new Padding(3, 4, 3, 4);
            txtGameName.Name = "txtGameName";
            txtGameName.ReadOnly = true;
            txtGameName.Size = new Size(659, 27);
            txtGameName.TabIndex = 21;
            txtGameName.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 71);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 23;
            label1.Text = "Name";
            // 
            // frmGameDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 391);
            Controls.Add(rtbRules);
            Controls.Add(label2);
            Controls.Add(txtGameName);
            Controls.Add(label1);
            Name = "frmGameDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmGameDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbRules;
        private Label label2;
        private TextBox txtGameName;
        private Label label1;
    }
}