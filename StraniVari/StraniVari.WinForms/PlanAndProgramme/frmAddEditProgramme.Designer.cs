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
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtTheme = new TextBox();
            txtName = new TextBox();
            btnSave = new Button();
            label5 = new Label();
            label4 = new Label();
            dtpEndDatePP = new DateTimePicker();
            dtpStartDatePP = new DateTimePicker();
            label3 = new Label();
            rtbRules = new RichTextBox();
            label2 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(365, 381);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(217, 19);
            txtEndDate.TabIndex = 47;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(365, 428);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(217, 19);
            txtStartDate.TabIndex = 46;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(365, 336);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(217, 19);
            txtTheme.TabIndex = 45;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(365, 301);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(217, 19);
            txtName.TabIndex = 44;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(1131, 547);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(642, 308);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 42;
            label5.Text = "End date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(642, 252);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 41;
            label4.Text = "Start date";
            // 
            // dtpEndDatePP
            // 
            dtpEndDatePP.Location = new Point(733, 301);
            dtpEndDatePP.Name = "dtpEndDatePP";
            dtpEndDatePP.Size = new Size(566, 27);
            dtpEndDatePP.TabIndex = 40;
            // 
            // dtpStartDatePP
            // 
            dtpStartDatePP.Location = new Point(733, 245);
            dtpStartDatePP.Name = "dtpStartDatePP";
            dtpStartDatePP.Size = new Size(566, 27);
            dtpStartDatePP.TabIndex = 39;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(604, 56);
            label3.Name = "label3";
            label3.Size = new Size(1, 644);
            label3.TabIndex = 38;
            // 
            // rtbRules
            // 
            rtbRules.Location = new Point(733, 374);
            rtbRules.Name = "rtbRules";
            rtbRules.Size = new Size(566, 155);
            rtbRules.TabIndex = 36;
            rtbRules.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(642, 423);
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
            ClientSize = new Size(1638, 777);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtTheme);
            Controls.Add(txtName);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpEndDatePP);
            Controls.Add(dtpStartDatePP);
            Controls.Add(label3);
            Controls.Add(rtbRules);
            Controls.Add(label2);
            Name = "frmAddEditProgramme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditProgramme";
            Load += frmAddEditProgramme_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtTheme;
        private TextBox txtName;
        private Button btnSave;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpEndDatePP;
        private DateTimePicker dtpStartDatePP;
        private Label label3;
        private RichTextBox rtbRules;
        private Label label2;
        private ErrorProvider err;
    }
}