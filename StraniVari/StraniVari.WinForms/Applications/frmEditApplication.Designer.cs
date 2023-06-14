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
            txtTripDatTime = new TextBox();
            txtTripPlace = new TextBox();
            txtSchool = new TextBox();
            label4 = new Label();
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtName = new TextBox();
            txtTheme = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtFristName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtTripDatTime
            // 
            txtTripDatTime.BorderStyle = BorderStyle.None;
            txtTripDatTime.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTripDatTime.Location = new Point(512, 447);
            txtTripDatTime.Name = "txtTripDatTime";
            txtTripDatTime.ReadOnly = true;
            txtTripDatTime.Size = new Size(248, 19);
            txtTripDatTime.TabIndex = 43;
            // 
            // txtTripPlace
            // 
            txtTripPlace.BorderStyle = BorderStyle.None;
            txtTripPlace.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTripPlace.Location = new Point(512, 422);
            txtTripPlace.Name = "txtTripPlace";
            txtTripPlace.ReadOnly = true;
            txtTripPlace.Size = new Size(248, 19);
            txtTripPlace.TabIndex = 42;
            // 
            // txtSchool
            // 
            txtSchool.BorderStyle = BorderStyle.None;
            txtSchool.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSchool.Location = new Point(512, 397);
            txtSchool.Name = "txtSchool";
            txtSchool.ReadOnly = true;
            txtSchool.Size = new Size(248, 19);
            txtSchool.TabIndex = 41;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(782, 221);
            label4.Name = "label4";
            label4.Size = new Size(1, 293);
            label4.TabIndex = 40;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(512, 367);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(248, 19);
            txtEndDate.TabIndex = 39;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(512, 333);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(248, 19);
            txtStartDate.TabIndex = 37;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(512, 267);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(248, 19);
            txtName.TabIndex = 35;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(512, 300);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(248, 19);
            txtTheme.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 212);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(812, 266);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 44;
            label2.Text = "First name";
            // 
            // txtFristName
            // 
            txtFristName.Location = new Point(912, 267);
            txtFristName.Margin = new Padding(2);
            txtFristName.Name = "txtFristName";
            txtFristName.ReadOnly = true;
            txtFristName.Size = new Size(335, 27);
            txtFristName.TabIndex = 45;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(912, 321);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(336, 27);
            txtLastName.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(812, 328);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 46;
            label3.Text = "Last name";
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(1157, 439);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(912, 379);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(335, 28);
            comboBox1.TabIndex = 49;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(812, 387);
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
            ClientSize = new Size(1638, 777);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(btnSave);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFristName);
            Controls.Add(label2);
            Controls.Add(txtTripDatTime);
            Controls.Add(txtTripPlace);
            Controls.Add(txtSchool);
            Controls.Add(label4);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtName);
            Controls.Add(txtTheme);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmEditApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditApplication";
            Load += frmEditApplication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTripDatTime;
        private TextBox txtTripPlace;
        private TextBox txtSchool;
        private Label label4;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtName;
        private TextBox txtTheme;
        private Label label1;
        private Label label2;
        private TextBox txtFristName;
        private TextBox txtLastName;
        private Label label3;
        private Button btnSave;
        private ComboBox comboBox1;
        private Label label5;
    }
}