namespace StraniVari.WinUI.Games
{
    partial class frmAllGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllGames));
            listBox1 = new ListBox();
            btnAddGame = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(439, 253);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1076, 304);
            listBox1.TabIndex = 1;
            // 
            // btnAddGame
            // 
            btnAddGame.Cursor = Cursors.Hand;
            btnAddGame.Location = new Point(439, 206);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(149, 29);
            btnAddGame.TabIndex = 16;
            btnAddGame.Text = "Add game";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Location = new Point(1237, 206);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(132, 29);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit game";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(1386, 206);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 28);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete game";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 216);
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
            label4.Location = new Point(364, 64);
            label4.Name = "label4";
            label4.Size = new Size(1, 644);
            label4.TabIndex = 77;
            // 
            // frmAllGames
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 777);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAddGame);
            Controls.Add(listBox1);
            Cursor = Cursors.Hand;
            Name = "frmAllGames";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAllGames";
            Load += frmAllGames_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button btnAddGame;
        private Button btnEdit;
        private Button btnDelete;
        private PictureBox pictureBox2;
        private Label label4;
    }
}