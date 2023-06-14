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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditTrip));
            err = new ErrorProvider(components);
            label1 = new Label();
            txtPlace = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnTrip = new Button();
            comboBox1 = new ComboBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(752, 252);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 16;
            label1.Text = "Place";
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(853, 252);
            txtPlace.Margin = new Padding(2);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(285, 27);
            txtPlace.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(752, 319);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 18;
            label2.Text = "Date Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(853, 312);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(285, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // btnTrip
            // 
            btnTrip.Cursor = Cursors.Hand;
            btnTrip.Location = new Point(1048, 420);
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
            comboBox1.Location = new Point(853, 368);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 28);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(388, 206);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 330);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(707, 54);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(752, 376);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 79;
            label3.Text = "Status";
            // 
            // frmAddEditTrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(btnTrip);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtPlace);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmAddEditTrip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditTrip";
            Load += frmAddEditTrip_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label4;
        private Label label3;
    }
}