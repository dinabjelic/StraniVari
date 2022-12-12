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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEvent.Location = new System.Drawing.Point(782, 68);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(939, 329);
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
            this.btnAddSchool});
            this.dgvEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.Location = new System.Drawing.Point(3, 24);
            this.dgvEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(933, 301);
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
            // frmAllEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 447);
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn StraniVariTheme;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnAddSchool;
    }
}