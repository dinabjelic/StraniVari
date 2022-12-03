namespace StraniVari.WinUI.Event
{
    partial class frmEvents
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.btnShowEvents = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEvents);
            this.groupBox1.Location = new System.Drawing.Point(13, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EVENTS";
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.Location = new System.Drawing.Point(3, 18);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(769, 328);
            this.dgvEvents.TabIndex = 0;
            // 
            // btnShowEvents
            // 
            this.btnShowEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowEvents.Location = new System.Drawing.Point(666, 60);
            this.btnShowEvents.Name = "btnShowEvents";
            this.btnShowEvents.Size = new System.Drawing.Size(119, 23);
            this.btnShowEvents.TabIndex = 1;
            this.btnShowEvents.Text = "Show Events";
            this.btnShowEvents.UseVisualStyleBackColor = true;
            this.btnShowEvents.Click += new System.EventHandler(this.btnShowEvents_Click);
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowEvents);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEvents";
            this.Text = "frmEvents";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button btnShowEvents;
    }
}