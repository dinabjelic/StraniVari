namespace StraniVari.WinUI.SchoolDetails
{
    partial class frmShoolsForEvent
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
            this.lbxSchools = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.btnAddSchoolToEvent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxSchools
            // 
            this.lbxSchools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxSchools.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxSchools.FormattingEnabled = true;
            this.lbxSchools.ItemHeight = 20;
            this.lbxSchools.Location = new System.Drawing.Point(354, 81);
            this.lbxSchools.Name = "lbxSchools";
            this.lbxSchools.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxSchools.Size = new System.Drawing.Size(349, 144);
            this.lbxSchools.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(354, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose schools for event";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDate.Location = new System.Drawing.Point(58, 180);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(248, 19);
            this.txtEndDate.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(58, 81);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(248, 19);
            this.txtName.TabIndex = 1;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDate.Location = new System.Drawing.Point(58, 147);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(248, 19);
            this.txtStartDate.TabIndex = 3;
            // 
            // txtTheme
            // 
            this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheme.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheme.Location = new System.Drawing.Point(58, 114);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(248, 19);
            this.txtTheme.TabIndex = 2;
            // 
            // btnAddSchoolToEvent
            // 
            this.btnAddSchoolToEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSchoolToEvent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddSchoolToEvent.Location = new System.Drawing.Point(545, 239);
            this.btnAddSchoolToEvent.Name = "btnAddSchoolToEvent";
            this.btnAddSchoolToEvent.Size = new System.Drawing.Size(158, 29);
            this.btnAddSchoolToEvent.TabIndex = 5;
            this.btnAddSchoolToEvent.Text = "Add to event";
            this.btnAddSchoolToEvent.UseVisualStyleBackColor = true;
            this.btnAddSchoolToEvent.Click += new System.EventHandler(this.btnAddSchoolToEvent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(317, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(307, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 219);
            this.label4.TabIndex = 7;
            // 
            // frmShoolsForEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddSchoolToEvent);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxSchools);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmShoolsForEvent";
            this.Text = "frmShoolsForEvent";
            this.Load += new System.EventHandler(this.frmShoolsForEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckedListBox checkedListBox1;
        private ListBox lbxSchools;
        private Label label1;
        private Label label2;
        private GroupBox gBEventDetails;
        private TextBox txtStartDate;
        private TextBox txtTheme;
        private TextBox txtName;
        private TextBox txtEndDate;
        private Button btnAddSchoolToEvent;
        private Label label3;
        private Label label4;
    }
}