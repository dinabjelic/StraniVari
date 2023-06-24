namespace StraniVari.WinUI.Trip
{
    partial class frmAddEditTrip
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
            err = new ErrorProvider(components);
            label1 = new Label();
            txtPlace = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnTrip = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            lblName = new Label();
            sideBar1 = new Material.SideBar();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 235);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 16;
            label1.Text = "Place";
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(675, 235);
            txtPlace.Margin = new Padding(2);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(285, 27);
            txtPlace.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 302);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 18;
            label2.Text = "Date Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(675, 295);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(285, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // btnTrip
            // 
            btnTrip.Cursor = Cursors.Hand;
            btnTrip.Location = new Point(870, 403);
            btnTrip.Margin = new Padding(2);
            btnTrip.Name = "btnTrip";
            btnTrip.Size = new Size(90, 27);
            btnTrip.TabIndex = 20;
            btnTrip.Text = "Save";
            btnTrip.UseVisualStyleBackColor = true;
            btnTrip.Click += btnTrip_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(675, 351);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 28);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(574, 359);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 79;
            label3.Text = "Event";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1459, 7);
            label4.Name = "label4";
            label4.Size = new Size(1, 25);
            label4.TabIndex = 82;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ButtonHighlight;
            lblName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(1466, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 81;
            lblName.Text = "label1";
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Left;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(391, 677);
            sideBar1.TabIndex = 83;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(473, 82);
            label5.Name = "label5";
            label5.Size = new Size(179, 50);
            label5.TabIndex = 88;
            label5.Text = "Trips";
            // 
            // frmAddEditTrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1146, 677);
            Controls.Add(label5);
            Controls.Add(sideBar1);
            Controls.Add(label4);
            Controls.Add(lblName);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(btnTrip);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtPlace);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmAddEditTrip";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEditTrip_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider err;
        private TextBox txtPlace;
        private Label label1;
        private Button btnTrip;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox comboBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label lblName;
        private Material.SideBar sideBar1;
        private Label label5;
    }
}