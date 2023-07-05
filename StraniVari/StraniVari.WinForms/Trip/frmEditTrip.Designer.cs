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
            this.components = new System.ComponentModel.Container();
            this.btnTrip = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrip
            // 
            this.btnTrip.BackColor = System.Drawing.SystemColors.Window;
            this.btnTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrip.Location = new System.Drawing.Point(316, 130);
            this.btnTrip.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(90, 27);
            this.btnTrip.TabIndex = 84;
            this.btnTrip.Text = "Save";
            this.btnTrip.UseVisualStyleBackColor = false;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 83);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 27);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Date Time";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(121, 23);
            this.txtPlace.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(285, 27);
            this.txtPlace.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Place";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmEditTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(435, 184);
            this.Controls.Add(this.btnTrip);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.label1);
            this.Name = "frmEditTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmEditTrip_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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