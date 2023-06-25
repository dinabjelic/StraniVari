namespace StraniVari.WinUI.PlanAndProgramme
{
    partial class frmAddEditProgramme
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
            label5 = new Label();
            label4 = new Label();
            dtpEndDatePP = new DateTimePicker();
            dtpStartDatePP = new DateTimePicker();
            rtbRules = new RichTextBox();
            label2 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Window;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(580, 319);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 92);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 42;
            label5.Text = "End date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 36);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 41;
            label4.Text = "Start date";
            // 
            // dtpEndDatePP
            // 
            dtpEndDatePP.Location = new Point(108, 85);
            dtpEndDatePP.Name = "dtpEndDatePP";
            dtpEndDatePP.Size = new Size(566, 27);
            dtpEndDatePP.TabIndex = 40;
            // 
            // dtpStartDatePP
            // 
            dtpStartDatePP.Location = new Point(108, 29);
            dtpStartDatePP.Name = "dtpStartDatePP";
            dtpStartDatePP.Size = new Size(566, 27);
            dtpStartDatePP.TabIndex = 39;
            // 
            // rtbRules
            // 
            rtbRules.Location = new Point(108, 158);
            rtbRules.Name = "rtbRules";
            rtbRules.Size = new Size(566, 155);
            rtbRules.TabIndex = 36;
            rtbRules.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 207);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 37;
            label2.Text = "Activities";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmAddEditProgramme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(693, 377);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpEndDatePP);
            Controls.Add(dtpStartDatePP);
            Controls.Add(rtbRules);
            Controls.Add(label2);
            Name = "frmAddEditProgramme";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEditProgramme_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpEndDatePP;
        private DateTimePicker dtpStartDatePP;
        private RichTextBox rtbRules;
        private Label label2;
        private ErrorProvider err;
    }
}