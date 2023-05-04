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
            dgvPictures.Location = new Point(806, 12);
            dgvPictures.MultiSelect = false;
            dgvPictures.Name = "dgvPictures";
            dgvPictures.ReadOnly = true;
            dgvPictures.RowHeadersWidth = 51;
            dgvPictures.RowTemplate.Height = 29;
            dgvPictures.Size = new Size(191, 372);
            dgvPictures.TabIndex = 3;
            dgvPictures.CellDoubleClick += dgvPictures_CellClick;
            // 
            // btnAddPic
            // 
            btnAddPic.Location = new Point(832, 390);
            btnAddPic.Name = "btnAddPic";
            btnAddPic.Size = new Size(94, 29);
            btnAddPic.TabIndex = 4;
            btnAddPic.Text = "Add";
            btnAddPic.UseVisualStyleBackColor = true;
            btnAddPic.Click += btnAddPic_Click;
            // 
            // frmImages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 452);
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
    }
}