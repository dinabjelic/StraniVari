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
            this.components = new System.ComponentModel.Container();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDatePP = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDatePP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbRules = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDate.Location = new System.Drawing.Point(38, 209);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(217, 19);
            this.txtEndDate.TabIndex = 47;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDate.Location = new System.Drawing.Point(38, 256);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(217, 19);
            this.txtStartDate.TabIndex = 46;
            // 
            // txtTheme
            // 
            this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheme.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheme.Location = new System.Drawing.Point(38, 164);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(217, 19);
            this.txtTheme.TabIndex = 45;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(38, 129);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(217, 19);
            this.txtName.TabIndex = 44;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(559, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "End date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Start date";
            // 
            // dtpEndDatePP
            // 
            this.dtpEndDatePP.Location = new System.Drawing.Point(403, 145);
            this.dtpEndDatePP.Name = "dtpEndDatePP";
            this.dtpEndDatePP.Size = new System.Drawing.Size(250, 27);
            this.dtpEndDatePP.TabIndex = 40;
            // 
            // dtpStartDatePP
            // 
            this.dtpStartDatePP.Location = new System.Drawing.Point(403, 89);
            this.dtpStartDatePP.Name = "dtpStartDatePP";
            this.dtpStartDatePP.Size = new System.Drawing.Size(250, 27);
            this.dtpStartDatePP.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(276, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 386);
            this.label3.TabIndex = 38;
            // 
            // rtbRules
            // 
            this.rtbRules.Location = new System.Drawing.Point(403, 218);
            this.rtbRules.Name = "rtbRules";
            this.rtbRules.Size = new System.Drawing.Size(250, 120);
            this.rtbRules.TabIndex = 36;
            this.rtbRules.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Activities";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmAddEditProgramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEndDatePP);
            this.Controls.Add(this.dtpStartDatePP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbRules);
            this.Controls.Add(this.label2);
            this.Name = "frmAddEditProgramme";
            this.Text = "frmAddEditProgramme";
            this.Load += new System.EventHandler(this.frmAddEditProgramme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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