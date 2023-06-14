namespace StraniVari.WinUI.Notifications
{
    partial class frmAllNotifications
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
            label3 = new Label();
            groupBox1 = new GroupBox();
            dgvNotifications = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            MeetingTheme = new DataGridViewTextBoxColumn();
            MeetingPlace = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            MeetingDate = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnNotification = new Button();
            txtEndDate = new TextBox();
            txtStartDate = new TextBox();
            txtTheme = new TextBox();
            txtName = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(353, 79);
            label3.Name = "label3";
            label3.Size = new Size(1, 644);
            label3.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvNotifications);
            groupBox1.Location = new Point(377, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1081, 262);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Notifications";
            // 
            // dgvNotifications
            // 
            dgvNotifications.AllowUserToAddRows = false;
            dgvNotifications.AllowUserToDeleteRows = false;
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifications.Columns.AddRange(new DataGridViewColumn[] { Id, MeetingTheme, MeetingPlace, Address, City, MeetingDate, btnEdit, btnDelete });
            dgvNotifications.Cursor = Cursors.Hand;
            dgvNotifications.Dock = DockStyle.Fill;
            dgvNotifications.Location = new Point(3, 23);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.ReadOnly = true;
            dgvNotifications.RowHeadersWidth = 51;
            dgvNotifications.RowTemplate.Height = 29;
            dgvNotifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotifications.Size = new Size(1075, 236);
            dgvNotifications.TabIndex = 0;
            dgvNotifications.CellContentClick += dgvNotifications_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // MeetingTheme
            // 
            MeetingTheme.DataPropertyName = "meetingTheme";
            MeetingTheme.HeaderText = "Meeting Theme";
            MeetingTheme.MinimumWidth = 6;
            MeetingTheme.Name = "MeetingTheme";
            MeetingTheme.ReadOnly = true;
            MeetingTheme.Width = 200;
            // 
            // MeetingPlace
            // 
            MeetingPlace.DataPropertyName = "meetingPlace";
            MeetingPlace.HeaderText = "Meeting Place";
            MeetingPlace.MinimumWidth = 6;
            MeetingPlace.Name = "MeetingPlace";
            MeetingPlace.ReadOnly = true;
            MeetingPlace.Width = 250;
            // 
            // Address
            // 
            Address.DataPropertyName = "address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 125;
            // 
            // City
            // 
            City.DataPropertyName = "city";
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.ReadOnly = true;
            City.Width = 125;
            // 
            // MeetingDate
            // 
            MeetingDate.DataPropertyName = "meetingDate";
            MeetingDate.HeaderText = "Meeting Date";
            MeetingDate.MinimumWidth = 6;
            MeetingDate.Name = "MeetingDate";
            MeetingDate.ReadOnly = true;
            MeetingDate.Width = 135;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Options";
            btnEdit.MinimumWidth = 6;
            btnEdit.Name = "btnEdit";
            btnEdit.ReadOnly = true;
            btnEdit.Resizable = DataGridViewTriState.True;
            btnEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEdit.Text = "Edit";
            btnEdit.ToolTipText = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 90;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Options";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.ToolTipText = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 90;
            // 
            // btnNotification
            // 
            btnNotification.Cursor = Cursors.Hand;
            btnNotification.Location = new Point(1300, 219);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(158, 29);
            btnNotification.TabIndex = 17;
            btnNotification.Text = "Add notification";
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // txtEndDate
            // 
            txtEndDate.BorderStyle = BorderStyle.None;
            txtEndDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(121, 385);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(217, 19);
            txtEndDate.TabIndex = 21;
            // 
            // txtStartDate
            // 
            txtStartDate.BorderStyle = BorderStyle.None;
            txtStartDate.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(121, 432);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(217, 19);
            txtStartDate.TabIndex = 20;
            // 
            // txtTheme
            // 
            txtTheme.BorderStyle = BorderStyle.None;
            txtTheme.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheme.Location = new Point(121, 340);
            txtTheme.Name = "txtTheme";
            txtTheme.ReadOnly = true;
            txtTheme.Size = new Size(217, 19);
            txtTheme.TabIndex = 19;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(121, 305);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(217, 19);
            txtName.TabIndex = 18;
            // 
            // frmAllNotifications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtTheme);
            Controls.Add(txtName);
            Controls.Add(btnNotification);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "frmAllNotifications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllNotifications";
            Load += frmAllNotifications_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private DataGridView dgvNotifications;
        private Button btnNotification;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtTheme;
        private TextBox txtName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MeetingTheme;
        private DataGridViewTextBoxColumn MeetingPlace;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn MeetingDate;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}