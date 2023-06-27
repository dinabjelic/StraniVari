namespace StraniVari.WinUI.Reports
{
    partial class frmReport
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
            btnGames = new Button();
            label1 = new Label();
            btnEventDetails = new Button();
            SuspendLayout();
            // 
            // btnGames
            // 
            btnGames.BackColor = SystemColors.Window;
            btnGames.Cursor = Cursors.Hand;
            btnGames.Location = new Point(71, 139);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(174, 35);
            btnGames.TabIndex = 90;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            btnGames.Click += btnGames_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(179, 50);
            label1.TabIndex = 88;
            label1.Text = "Reports";
            // 
            // btnEventDetails
            // 
            btnEventDetails.BackColor = SystemColors.Window;
            btnEventDetails.Cursor = Cursors.Hand;
            btnEventDetails.Location = new Point(71, 93);
            btnEventDetails.Name = "btnEventDetails";
            btnEventDetails.Size = new Size(174, 40);
            btnEventDetails.TabIndex = 89;
            btnEventDetails.Text = "Event details";
            btnEventDetails.UseVisualStyleBackColor = false;
            btnEventDetails.Click += btnEventDetails_Click;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(321, 224);
            Controls.Add(btnEventDetails);
            Controls.Add(label1);
            Controls.Add(btnGames);
            Name = "frmReport";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGames;
        private Label label1;
        private Button btnEventDetails;
    }
}