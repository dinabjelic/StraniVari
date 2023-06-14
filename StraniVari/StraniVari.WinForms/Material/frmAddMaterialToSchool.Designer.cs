namespace StraniVari.WinUI.Material
{
    partial class frmAddMaterialToSchool
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
            btnAddMaterialToSchool = new Button();
            label2 = new Label();
            lbxMaterial = new ListBox();
            label4 = new Label();
            label3 = new Label();
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtName = new TextBox();
            txtTheme = new TextBox();
            label1 = new Label();
            txtSchool = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnView = new Button();
            btnRecommend = new Button();
            SuspendLayout();
            // 
            // btnAddMaterialToSchool
            // 
            btnAddMaterialToSchool.Cursor = Cursors.Hand;
            btnAddMaterialToSchool.ForeColor = SystemColors.ActiveCaptionText;
            btnAddMaterialToSchool.Location = new Point(1089, 140);
            btnAddMaterialToSchool.Name = "btnAddMaterialToSchool";
            btnAddMaterialToSchool.Size = new Size(158, 29);
            btnAddMaterialToSchool.TabIndex = 16;
            btnAddMaterialToSchool.Text = "Add to school";
            btnAddMaterialToSchool.UseVisualStyleBackColor = true;
            btnAddMaterialToSchool.Click += btnAddMaterialToSchool_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(580, 199);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 15;
            label2.Text = "Choose material for school";
            // 
            // lbxMaterial
            // 
            lbxMaterial.Cursor = Cursors.Hand;
            lbxMaterial.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbxMaterial.FormattingEnabled = true;
            lbxMaterial.ItemHeight = 20;
            lbxMaterial.Location = new Point(580, 231);
            lbxMaterial.Name = "lbxMaterial";
            lbxMaterial.SelectionMode = SelectionMode.MultiSimple;
            lbxMaterial.Size = new Size(664, 244);
            lbxMaterial.TabIndex = 14;
            lbxMaterial.SelectedIndexChanged += lbxMaterial_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(540, 36);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuText;
            label3.Location = new Point(543, 258);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 22;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(286, 377);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(248, 19);
            txtEndDate.TabIndex = 21;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(286, 344);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(248, 19);
            txtStartDate.TabIndex = 19;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(286, 278);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(248, 19);
            txtName.TabIndex = 17;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(286, 311);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(248, 19);
            txtTheme.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 91);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 20;
            // 
            // txtSchool
            // 
            txtSchool.BorderStyle = BorderStyle.None;
            txtSchool.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchool.Location = new Point(286, 408);
            txtSchool.Name = "txtSchool";
            txtSchool.ReadOnly = true;
            txtSchool.Size = new Size(248, 19);
            txtSchool.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(1111, 199);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 39;
            label6.Text = "Selected items: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1230, 199);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 38;
            label5.Text = "0";
            // 
            // btnView
            // 
            btnView.Cursor = Cursors.Hand;
            btnView.ForeColor = SystemColors.ActiveCaptionText;
            btnView.Location = new Point(1051, 504);
            btnView.Name = "btnView";
            btnView.Size = new Size(193, 29);
            btnView.TabIndex = 40;
            btnView.Text = "View added material";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnRecommend
            // 
            btnRecommend.Cursor = Cursors.Hand;
            btnRecommend.Location = new Point(580, 504);
            btnRecommend.Name = "btnRecommend";
            btnRecommend.Size = new Size(193, 29);
            btnRecommend.TabIndex = 41;
            btnRecommend.Text = "See recommended";
            btnRecommend.UseVisualStyleBackColor = true;
            btnRecommend.Click += btnRecommend_Click;
            // 
            // frmAddMaterialToSchool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(btnRecommend);
            Controls.Add(btnView);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSchool);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtName);
            Controls.Add(txtTheme);
            Controls.Add(label1);
            Controls.Add(btnAddMaterialToSchool);
            Controls.Add(label2);
            Controls.Add(lbxMaterial);
            Name = "frmAddMaterialToSchool";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddMaterialToSchool";
            Load += frmAddMaterialToSchool_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddMaterialToSchool;
        private Label label2;
        private ListBox lbxMaterial;
        private Label label4;
        private Label label3;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtName;
        private TextBox txtTheme;
        private Label label1;
        private TextBox txtSchool;
        private Label label6;
        private Label label5;
        private Button btnView;
        private Button btnRecommend;
    }
}