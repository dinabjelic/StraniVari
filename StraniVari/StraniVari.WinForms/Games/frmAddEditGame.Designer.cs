namespace StraniVari.WinUI.Games
{
    partial class frmAddEditGame
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
            components = new System.ComponentModel.Container();
            btnSave = new Button();
            txtGameName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            rtbRules = new RichTextBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(692, 356);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 37);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(134, 48);
            txtGameName.Margin = new Padding(3, 4, 3, 4);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(659, 27);
            txtGameName.TabIndex = 1;
            txtGameName.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 55);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 193);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 20;
            label2.Text = "Rules";
            // 
            // rtbRules
            // 
            rtbRules.Location = new Point(134, 110);
            rtbRules.Name = "rtbRules";
            rtbRules.Size = new Size(659, 217);
            rtbRules.TabIndex = 2;
            rtbRules.Text = "";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmAddEditGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 421);
            Controls.Add(rtbRules);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtGameName);
            Controls.Add(label1);
            Name = "frmAddEditGame";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEditGame_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox txtGameName;
        private Label label1;
        private Label label2;
        private RichTextBox rtbRules;
        private ErrorProvider err;
    }
}