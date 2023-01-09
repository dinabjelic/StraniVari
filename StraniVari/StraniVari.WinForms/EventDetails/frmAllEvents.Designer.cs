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
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StraniVariTheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddSchool = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNotification = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnVolunteers = new System.Windows.Forms.Button();
            this.btnSchools = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEvent.Location = new System.Drawing.Point(1055, 79);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(181, 29);
            this.btnAddEvent.TabIndex = 3;
            this.btnAddEvent.Text = "Add new event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEvents);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1230, 329);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EVENTS";
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EventName,
            this.StraniVariTheme,
            this.startDate,
            this.endDate,
            this.btnDelete,
            this.btnEdit,
            this.btnAddSchool,
            this.btnNotification,
            this.dataGridViewButtonColumn1});
            this.dgvEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.Location = new System.Drawing.Point(3, 24);
            this.dgvEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(1224, 301);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // EventName
            // 
            this.EventName.DataPropertyName = "name";
            this.EventName.HeaderText = "Name";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Width = 125;
            // 
            // StraniVariTheme
            // 
            this.StraniVariTheme.DataPropertyName = "straniVariTheme";
            this.StraniVariTheme.HeaderText = "StraniVariTheme";
            this.StraniVariTheme.MinimumWidth = 6;
            this.StraniVariTheme.Name = "StraniVariTheme";
            this.StraniVariTheme.ReadOnly = true;
            this.StraniVariTheme.Width = 125;
            // 
            // startDate
            // 
            this.startDate.DataPropertyName = "startDate";
            this.startDate.HeaderText = "startDate";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 125;
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "endDate";
            this.endDate.HeaderText = "endDate";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Action";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Edit";
            this.btnDelete.ToolTipText = "Edit";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 126;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Action";
            this.btnEdit.MinimumWidth = 6;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Text = "Delete";
            this.btnEdit.ToolTipText = "Delete";
            this.btnEdit.UseColumnTextForButtonValue = true;
            this.btnEdit.Width = 125;
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.HeaderText = "Action";
            this.btnAddSchool.MinimumWidth = 6;
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.ReadOnly = true;
            this.btnAddSchool.Text = "Add school";
            this.btnAddSchool.ToolTipText = "Add school";
            this.btnAddSchool.UseColumnTextForButtonValue = true;
            this.btnAddSchool.Width = 125;
            // 
            // btnNotification
            // 
            this.btnNotification.HeaderText = "Option";
            this.btnNotification.MinimumWidth = 6;
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.ReadOnly = true;
            this.btnNotification.Text = "Notification";
            this.btnNotification.ToolTipText = "Notification";
            this.btnNotification.UseColumnTextForButtonValue = true;
            this.btnNotification.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Option";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Plan and Programme";
            this.dataGridViewButtonColumn1.ToolTipText = "Plan and Programme";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 170;
            // 
            // btnMaterials
            // 
            this.btnMaterials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterials.Location = new System.Drawing.Point(15, 12);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(105, 29);
            this.btnMaterials.TabIndex = 4;
            this.btnMaterials.Text = "Materials";
            this.btnMaterials.UseVisualStyleBackColor = true;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnVolunteers
            // 
            this.btnVolunteers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolunteers.Location = new System.Drawing.Point(116, 12);
            this.btnVolunteers.Name = "btnVolunteers";
            this.btnVolunteers.Size = new System.Drawing.Size(104, 29);
            this.btnVolunteers.TabIndex = 5;
            this.btnVolunteers.Text = "Volunteers";
            this.btnVolunteers.UseVisualStyleBackColor = true;
            this.btnVolunteers.Click += new System.EventHandler(this.btnVolunteers_Click);
            // 
            // btnSchools
            // 
            this.btnSchools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchools.Location = new System.Drawing.Point(214, 12);
            this.btnSchools.Name = "btnSchools";
            this.btnSchools.Size = new System.Drawing.Size(99, 29);
            this.btnSchools.TabIndex = 6;
            this.btnSchools.Text = "Schools";
            this.btnSchools.UseVisualStyleBackColor = true;
            this.btnSchools.Click += new System.EventHandler(this.btnSchools_Click);
            // 
            // btnGames
            // 
            this.btnGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGames.Location = new System.Drawing.Point(309, 12);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(104, 29);
            this.btnGames.TabIndex = 7;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(1142, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 29);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // frmAllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 447);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnSchools);
            this.Controls.Add(this.btnVolunteers);
            this.Controls.Add(this.btnMaterials);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAllEvents";
            this.Text = "frmAllEvents";
            this.Load += new System.EventHandler(this.frmAllEvents_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddEvent;
        private GroupBox groupBox1;
        private DataGridView dgvEvents;
        private Button btnMaterials;
        private Button btnVolunteers;
        private Button btnSchools;
        private Button btnGames;
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
        private Button btnReport;
    }
}