namespace StraniVari.WinUI.Reports
{
    partial class frmEventDetailsReport
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnGenerateReport = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(241, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(203, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Events";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 38);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Schools";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = SystemColors.Window;
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.Location = new Point(149, 128);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(182, 29);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += button1_Click;
            // 
            // frmEventDetailsReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(485, 179);
            Controls.Add(btnGenerateReport);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "frmEventDetailsReport";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmReport_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Button btnGenerateReport;
    }
}