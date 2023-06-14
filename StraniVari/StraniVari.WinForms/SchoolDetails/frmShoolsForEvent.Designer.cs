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
            lbxSchools = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtEndDate = new TextBox();
            txtName = new TextBox();
            txtStartDate = new TextBox();
            txtTheme = new TextBox();
            btnAddSchoolToEvent = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnView = new Button();
            SuspendLayout();
            // 
            // lbxSchools
            // 
            lbxSchools.Cursor = Cursors.Hand;
            lbxSchools.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbxSchools.FormattingEnabled = true;
            lbxSchools.ItemHeight = 20;
            lbxSchools.Location = new Point(602, 259);
            lbxSchools.Name = "lbxSchools";
            lbxSchools.SelectionMode = SelectionMode.MultiSimple;
            lbxSchools.Size = new Size(664, 244);
            lbxSchools.TabIndex = 2;
            lbxSchools.SelectedIndexChanged += lbxSchools_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 264);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(602, 219);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 4;
            label2.Text = "Choose schools for event";
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(309, 418);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(248, 19);
            txtEndDate.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(309, 319);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(248, 19);
            txtName.TabIndex = 1;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(309, 385);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(248, 19);
            txtStartDate.TabIndex = 3;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(309, 352);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(248, 19);
            txtTheme.TabIndex = 2;
            // 
            // btnAddSchoolToEvent
            // 
            btnAddSchoolToEvent.Cursor = Cursors.Hand;
            btnAddSchoolToEvent.ForeColor = SystemColors.ActiveCaptionText;
            btnAddSchoolToEvent.Location = new Point(1108, 527);
            btnAddSchoolToEvent.Name = "btnAddSchoolToEvent";
            btnAddSchoolToEvent.Size = new Size(158, 29);
            btnAddSchoolToEvent.TabIndex = 5;
            btnAddSchoolToEvent.Text = "Add to event";
            btnAddSchoolToEvent.UseVisualStyleBackColor = true;
            btnAddSchoolToEvent.Click += btnAddSchoolToEvent_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuText;
            label3.Location = new Point(573, 274);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(566, 74);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1252, 219);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 8;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(1140, 219);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 9;
            label6.Text = "Selected items: ";
            // 
            // btnView
            // 
            btnView.Cursor = Cursors.Hand;
            btnView.ForeColor = SystemColors.ActiveCaptionText;
            btnView.Location = new Point(602, 527);
            btnView.Name = "btnView";
            btnView.Size = new Size(193, 29);
            btnView.TabIndex = 10;
            btnView.Text = "View added schools";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // frmShoolsForEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(btnView);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAddSchoolToEvent);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtName);
            Controls.Add(txtTheme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbxSchools);
            ForeColor = SystemColors.ControlLightLight;
            Name = "frmShoolsForEvent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShoolsForEvent";
            Load += frmShoolsForEvent_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Label label5;
        private Label label6;
        private Button btnView;
    }
}