namespace StraniVari.WinUI.EventDetails
{
    partial class frmNewEvent
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
            btnAddNewEvent = new Button();
            txtStraniVariTheme = new TextBox();
            label4 = new Label();
            dtpStarDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            txtEventName = new TextBox();
            label2 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnAddNewEvent
            // 
            btnAddNewEvent.Cursor = Cursors.Hand;
            btnAddNewEvent.Location = new Point(395, 249);
            btnAddNewEvent.Name = "btnAddNewEvent";
            btnAddNewEvent.Size = new Size(94, 29);
            btnAddNewEvent.TabIndex = 20;
            btnAddNewEvent.Text = "Save";
            btnAddNewEvent.UseVisualStyleBackColor = true;
            btnAddNewEvent.Click += btnAddNewEvent_Click;
            // 
            // txtStraniVariTheme
            // 
            txtStraniVariTheme.Location = new Point(189, 108);
            txtStraniVariTheme.Name = "txtStraniVariTheme";
            txtStraniVariTheme.Size = new Size(300, 27);
            txtStraniVariTheme.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 115);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 22;
            label4.Text = "Strani vari theme";
            // 
            // dtpStarDate
            // 
            dtpStarDate.Location = new Point(189, 156);
            dtpStarDate.Name = "dtpStarDate";
            dtpStarDate.Size = new Size(300, 27);
            dtpStarDate.TabIndex = 17;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(189, 202);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 27);
            dtpEndDate.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 209);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 21;
            label3.Text = "End date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 163);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 19;
            label1.Text = "Start date";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(189, 59);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(300, 27);
            txtEventName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 66);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 16;
            label2.Text = "Event name";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNewEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 330);
            Controls.Add(btnAddNewEvent);
            Controls.Add(txtStraniVariTheme);
            Controls.Add(label4);
            Controls.Add(dtpStarDate);
            Controls.Add(dtpEndDate);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtEventName);
            Controls.Add(label2);
            Name = "frmNewEvent";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmNewEvent_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNewEvent;
        private TextBox txtStraniVariTheme;
        private Label label4;
        private DateTimePicker dtpStarDate;
        private DateTimePicker dtpEndDate;
        private Label label3;
        private Label label1;
        private TextBox txtEventName;
        private Label label2;
        private ErrorProvider err;
    }
}