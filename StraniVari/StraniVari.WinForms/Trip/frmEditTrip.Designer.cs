namespace StraniVari.WinUI.Trip
{
    partial class frmEditTrip
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
            btnTrip = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            txtPlace = new TextBox();
            label1 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnTrip
            // 
            btnTrip.BackColor = SystemColors.Window;
            btnTrip.Cursor = Cursors.Hand;
            btnTrip.Location = new Point(316, 130);
            btnTrip.Margin = new Padding(2);
            btnTrip.Name = "btnTrip";
            btnTrip.Size = new Size(90, 27);
            btnTrip.TabIndex = 84;
            btnTrip.Text = "Save";
            btnTrip.UseVisualStyleBackColor = false;
            btnTrip.Click += btnTrip_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 83);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(285, 27);
            dateTimePicker1.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 82;
            label2.Text = "Date Time";
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(121, 23);
            txtPlace.Margin = new Padding(2);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(285, 27);
            txtPlace.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 80;
            label1.Text = "Place";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmEditTrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(435, 184);
            Controls.Add(btnTrip);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtPlace);
            Controls.Add(label1);
            Name = "frmEditTrip";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmEditTrip_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrip;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox txtPlace;
        private Label label1;
        private ErrorProvider err;
    }
}