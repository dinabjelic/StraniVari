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
            btnShowMore = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            sideBar1 = new Material.SideBar();
            label1 = new Label();
            txtSearch = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // btnAddEvent
            // 
            btnAddEvent.BackColor = SystemColors.Window;
            btnAddEvent.Cursor = Cursors.Hand;
            btnAddEvent.Location = new Point(1234, 146);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(181, 29);
            btnAddEvent.TabIndex = 3;
            btnAddEvent.Text = "Add new event";
            btnAddEvent.UseVisualStyleBackColor = false;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvEvents);
            groupBox1.Location = new Point(421, 182);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(997, 329);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Columns.AddRange(new DataGridViewColumn[] { Id, EventName, StraniVariTheme, startDate, endDate, btnShowMore, btnDelete });
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
            dgvEvents.Size = new Size(991, 301);
            dgvEvents.TabIndex = 0;
            dgvEvents.CellContentClick += dgvEvents_CellContentClick;
            dgvEvents.CellMouseDoubleClick += dgvEvents_CellMouseDoubleClick;
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
            // btnShowMore
            // 
            btnShowMore.HeaderText = "Action";
            btnShowMore.MinimumWidth = 6;
            btnShowMore.Name = "btnShowMore";
            btnShowMore.ReadOnly = true;
            btnShowMore.Resizable = DataGridViewTriState.True;
            btnShowMore.SortMode = DataGridViewColumnSortMode.Automatic;
            btnShowMore.Text = "Details";
            btnShowMore.ToolTipText = "Details";
            btnShowMore.UseColumnTextForButtonValue = true;
            btnShowMore.Width = 125;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Action";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.ToolTipText = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 126;
            // 
            // sideBar1
            // 
            sideBar1.Dock = DockStyle.Left;
            sideBar1.Location = new Point(0, 0);
            sideBar1.Name = "sideBar1";
            sideBar1.Size = new Size(392, 606);
            sideBar1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(424, 56);
            label1.Name = "label1";
            label1.Size = new Size(179, 50);
            label1.TabIndex = 88;
            label1.Text = "Events";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1175, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "  Event name / Theme";
            txtSearch.Size = new Size(285, 27);
            txtSearch.TabIndex = 89;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // frmAllEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1472, 606);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(sideBar1);
            Controls.Add(btnAddEvent);
            Controls.Add(groupBox1);
            Name = "frmAllEvents";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAllEvents_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddEvent;
        private GroupBox groupBox1;
        private DataGridView dgvEvents;
        private Material.SideBar sideBar1;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn StraniVariTheme;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewButtonColumn btnShowMore;
        private DataGridViewButtonColumn btnDelete;
        private TextBox txtSearch;
    }
}