namespace StraniVari.WinUI.EventDetails
{
    partial class frmAllEvents
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
            btnAddEvent = new Button();
            groupBox1 = new GroupBox();
            dgvEvents = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            EventName = new DataGridViewTextBoxColumn();
            StraniVariTheme = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnAddSchool = new DataGridViewButtonColumn();
            btnNotification = new DataGridViewButtonColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            Applications = new DataGridViewButtonColumn();
            btnMaterials = new Button();
            btnVolunteers = new Button();
            btnSchools = new Button();
            btnGames = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // btnAddEvent
            // 
            btnAddEvent.Cursor = Cursors.Hand;
            btnAddEvent.Location = new Point(1418, 223);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(181, 29);
            btnAddEvent.TabIndex = 3;
            btnAddEvent.Text = "Add new event";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvEvents);
            groupBox1.Location = new Point(37, 259);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1565, 329);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "EVENTS";
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Columns.AddRange(new DataGridViewColumn[] { Id, EventName, StraniVariTheme, startDate, endDate, btnDelete, btnEdit, btnAddSchool, btnNotification, dataGridViewButtonColumn1, Applications });
            dgvEvents.Cursor = Cursors.Hand;
            dgvEvents.Dock = DockStyle.Fill;
            dgvEvents.GridColor = SystemColors.ControlDarkDark;
            dgvEvents.Location = new Point(3, 24);
            dgvEvents.Margin = new Padding(3, 4, 3, 4);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.RowTemplate.Height = 24;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(1559, 301);
            dgvEvents.TabIndex = 0;
            dgvEvents.CellContentClick += dgvEvents_CellContentClick;
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
            // EventName
            // 
            EventName.DataPropertyName = "name";
            EventName.HeaderText = "Name";
            EventName.MinimumWidth = 6;
            EventName.Name = "EventName";
            EventName.ReadOnly = true;
            EventName.Width = 160;
            // 
            // StraniVariTheme
            // 
            StraniVariTheme.DataPropertyName = "straniVariTheme";
            StraniVariTheme.HeaderText = "Theme";
            StraniVariTheme.MinimumWidth = 6;
            StraniVariTheme.Name = "StraniVariTheme";
            StraniVariTheme.ReadOnly = true;
            StraniVariTheme.Width = 160;
            // 
            // startDate
            // 
            startDate.DataPropertyName = "startDate";
            startDate.HeaderText = "Start Date";
            startDate.MinimumWidth = 6;
            startDate.Name = "startDate";
            startDate.ReadOnly = true;
            startDate.Width = 180;
            // 
            // endDate
            // 
            endDate.DataPropertyName = "endDate";
            endDate.HeaderText = "End Date";
            endDate.MinimumWidth = 6;
            endDate.Name = "endDate";
            endDate.ReadOnly = true;
            endDate.Width = 180;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Action";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Edit";
            btnDelete.ToolTipText = "Edit";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 126;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Action";
            btnEdit.MinimumWidth = 6;
            btnEdit.Name = "btnEdit";
            btnEdit.ReadOnly = true;
            btnEdit.Text = "Delete";
            btnEdit.ToolTipText = "Delete";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 125;
            // 
            // btnAddSchool
            // 
            btnAddSchool.HeaderText = "Action";
            btnAddSchool.MinimumWidth = 6;
            btnAddSchool.Name = "btnAddSchool";
            btnAddSchool.ReadOnly = true;
            btnAddSchool.Text = "Add school";
            btnAddSchool.ToolTipText = "Add school";
            btnAddSchool.UseColumnTextForButtonValue = true;
            btnAddSchool.Width = 125;
            // 
            // btnNotification
            // 
            btnNotification.HeaderText = "Option";
            btnNotification.MinimumWidth = 6;
            btnNotification.Name = "btnNotification";
            btnNotification.ReadOnly = true;
            btnNotification.Text = "Notification";
            btnNotification.ToolTipText = "Notification";
            btnNotification.UseColumnTextForButtonValue = true;
            btnNotification.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "Option";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Text = "Plan and Programme";
            dataGridViewButtonColumn1.ToolTipText = "Plan and Programme";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 170;
            // 
            // Applications
            // 
            Applications.HeaderText = "Action";
            Applications.MinimumWidth = 8;
            Applications.Name = "Applications";
            Applications.ReadOnly = true;
            Applications.Resizable = DataGridViewTriState.True;
            Applications.SortMode = DataGridViewColumnSortMode.Automatic;
            Applications.Text = "Applications";
            Applications.ToolTipText = "Applications";
            Applications.UseColumnTextForButtonValue = true;
            Applications.Width = 150;
            // 
            // btnMaterials
            // 
            btnMaterials.Cursor = Cursors.Hand;
            btnMaterials.Location = new Point(43, 192);
            btnMaterials.Name = "btnMaterials";
            btnMaterials.Size = new Size(105, 29);
            btnMaterials.TabIndex = 4;
            btnMaterials.Text = "Materials";
            btnMaterials.UseVisualStyleBackColor = true;
            btnMaterials.Click += btnMaterials_Click;
            // 
            // btnVolunteers
            // 
            btnVolunteers.Cursor = Cursors.Hand;
            btnVolunteers.Location = new Point(144, 192);
            btnVolunteers.Name = "btnVolunteers";
            btnVolunteers.Size = new Size(104, 29);
            btnVolunteers.TabIndex = 5;
            btnVolunteers.Text = "Volunteers";
            btnVolunteers.UseVisualStyleBackColor = true;
            btnVolunteers.Click += btnVolunteers_Click;
            // 
            // btnSchools
            // 
            btnSchools.Cursor = Cursors.Hand;
            btnSchools.Location = new Point(242, 192);
            btnSchools.Name = "btnSchools";
            btnSchools.Size = new Size(99, 29);
            btnSchools.TabIndex = 6;
            btnSchools.Text = "Schools";
            btnSchools.UseVisualStyleBackColor = true;
            btnSchools.Click += btnSchools_Click;
            // 
            // btnGames
            // 
            btnGames.Cursor = Cursors.Hand;
            btnGames.Location = new Point(337, 192);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(104, 29);
            btnGames.TabIndex = 7;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = true;
            btnGames.Click += btnGames_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(439, 192);
            button1.Name = "button1";
            button1.Size = new Size(104, 29);
            button1.TabIndex = 8;
            button1.Text = "Trips";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAllEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1638, 777);
            Controls.Add(button1);
            Controls.Add(btnGames);
            Controls.Add(btnSchools);
            Controls.Add(btnVolunteers);
            Controls.Add(btnMaterials);
            Controls.Add(btnAddEvent);
            Controls.Add(groupBox1);
            Name = "frmAllEvents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllEvents";
            Load += frmAllEvents_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddEvent;
        private GroupBox groupBox1;
        private DataGridView dgvEvents;
        private Button btnMaterials;
        private Button btnVolunteers;
        private Button btnSchools;
        private Button btnGames;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn StraniVariTheme;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnAddSchool;
        private DataGridViewButtonColumn btnNotification;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn Applications;
    }
}