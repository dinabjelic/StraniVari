namespace StraniVari.WinUI.Applications
{
    partial class frmEditApplication
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
            label2 = new Label();
            txtFristName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 35);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 44;
            label2.Text = "First name";
            // 
            // txtFristName
            // 
            txtFristName.Location = new Point(122, 36);
            txtFristName.Margin = new Padding(2);
            txtFristName.Name = "txtFristName";
            txtFristName.ReadOnly = true;
            txtFristName.Size = new Size(335, 27);
            txtFristName.TabIndex = 45;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(122, 90);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(336, 27);
            txtLastName.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 46;
            label3.Text = "Last name";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Window;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(367, 208);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(122, 148);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(335, 28);
            comboBox1.TabIndex = 49;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 156);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 50;
            label5.Text = "Status";
            // 
            // frmEditApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(487, 266);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(btnSave);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFristName);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "frmEditApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmEditApplication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtFristName;
        private TextBox txtLastName;
        private Label label3;
        private Button btnSave;
        private ComboBox comboBox1;
        private Label label5;
    }
}