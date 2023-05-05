namespace simple_media_center
{
    partial class frmImages
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
            pictureBox1 = new PictureBox();
            dgvPictures = new DataGridView();
            btnAddPic = new Button();
            btnMenu = new Button();
            btnDeleteAll = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPictures).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvPictures
            // 
            dgvPictures.AllowUserToAddRows = false;
            dgvPictures.AllowUserToDeleteRows = false;
            dgvPictures.AllowUserToResizeColumns = false;
            dgvPictures.AllowUserToResizeRows = false;
            dgvPictures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPictures.Location = new Point(806, 58);
            dgvPictures.MultiSelect = false;
            dgvPictures.Name = "dgvPictures";
            dgvPictures.ReadOnly = true;
            dgvPictures.RowHeadersWidth = 51;
            dgvPictures.RowTemplate.Height = 29;
            dgvPictures.Size = new Size(191, 326);
            dgvPictures.TabIndex = 3;
            dgvPictures.CellDoubleClick += dgvPictures_CellClick;
            // 
            // btnAddPic
            // 
            btnAddPic.Location = new Point(806, 390);
            btnAddPic.Name = "btnAddPic";
            btnAddPic.Size = new Size(94, 29);
            btnAddPic.TabIndex = 4;
            btnAddPic.Text = "Add";
            btnAddPic.UseVisualStyleBackColor = true;
            btnAddPic.Click += btnAddPic_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(817, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(165, 29);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Go back to menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(906, 433);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(94, 29);
            btnDeleteAll.TabIndex = 6;
            btnDeleteAll.Text = "Clear List";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(906, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmImages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 474);
            Controls.Add(btnDelete);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnMenu);
            Controls.Add(btnAddPic);
            Controls.Add(dgvPictures);
            Controls.Add(pictureBox1);
            Name = "frmImages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Images";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPictures).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvPictures;
        private Button btnAddPic;
        private Button btnMenu;
        private Button btnDeleteAll;
        private Button btnDelete;
    }
}