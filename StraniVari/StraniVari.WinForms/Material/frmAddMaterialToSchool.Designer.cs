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
            this.btnAddMaterialToSchool = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxMaterial = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMaterialToSchool
            // 
            this.btnAddMaterialToSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMaterialToSchool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMaterialToSchool.Location = new System.Drawing.Point(536, 251);
            this.btnAddMaterialToSchool.Name = "btnAddMaterialToSchool";
            this.btnAddMaterialToSchool.Size = new System.Drawing.Size(158, 29);
            this.btnAddMaterialToSchool.TabIndex = 16;
            this.btnAddMaterialToSchool.Text = "Add to school";
            this.btnAddMaterialToSchool.UseVisualStyleBackColor = true;
            this.btnAddMaterialToSchool.Click += new System.EventHandler(this.btnAddMaterialToSchool_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(337, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose material for school";
            // 
            // lbxMaterial
            // 
            this.lbxMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbxMaterial.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxMaterial.FormattingEnabled = true;
            this.lbxMaterial.ItemHeight = 20;
            this.lbxMaterial.Location = new System.Drawing.Point(337, 93);
            this.lbxMaterial.Name = "lbxMaterial";
            this.lbxMaterial.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxMaterial.Size = new System.Drawing.Size(357, 144);
            this.lbxMaterial.TabIndex = 14;
            this.lbxMaterial.SelectedIndexChanged += new System.EventHandler(this.lbxMaterial_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(298, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 219);
            this.label4.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(308, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 22;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndDate.Location = new System.Drawing.Point(49, 179);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(248, 19);
            this.txtEndDate.TabIndex = 21;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartDate.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartDate.Location = new System.Drawing.Point(49, 146);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(248, 19);
            this.txtStartDate.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(49, 80);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(248, 19);
            this.txtName.TabIndex = 17;
            // 
            // txtTheme
            // 
            this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheme.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTheme.Location = new System.Drawing.Point(49, 113);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.ReadOnly = true;
            this.txtTheme.Size = new System.Drawing.Size(248, 19);
            this.txtTheme.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 20;
            // 
            // txtSchool
            // 
            this.txtSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSchool.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSchool.Location = new System.Drawing.Point(49, 210);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.ReadOnly = true;
            this.txtSchool.Size = new System.Drawing.Size(248, 19);
            this.txtSchool.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(548, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Selected items: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(660, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "0";
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnView.Location = new System.Drawing.Point(337, 251);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(193, 29);
            this.btnView.TabIndex = 40;
            this.btnView.Text = "View added material";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmAddMaterialToSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 349);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMaterialToSchool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxMaterial);
            this.Name = "frmAddMaterialToSchool";
            this.Text = "frmAddMaterialToSchool";
            this.Load += new System.EventHandler(this.frmAddMaterialToSchool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}