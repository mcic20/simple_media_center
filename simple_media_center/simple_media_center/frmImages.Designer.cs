﻿namespace simple_media_center
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
            btnLastImage = new Button();
            btnNextImage = new Button();
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
            // btnLastImage
            // 
            btnLastImage.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLastImage.Location = new Point(229, 464);
            btnLastImage.Name = "btnLastImage";
            btnLastImage.Size = new Size(94, 44);
            btnLastImage.TabIndex = 1;
            btnLastImage.Text = "<";
            btnLastImage.UseVisualStyleBackColor = true;
            // 
            // btnNextImage
            // 
            btnNextImage.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextImage.Location = new Point(372, 464);
            btnNextImage.Name = "btnNextImage";
            btnNextImage.Size = new Size(94, 44);
            btnNextImage.TabIndex = 2;
            btnNextImage.Text = ">";
            btnNextImage.UseVisualStyleBackColor = true;
            // 
            // dgvPictures
            // 
            dgvPictures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPictures.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPictures.Location = new Point(806, 12);
            dgvPictures.Name = "dgvPictures";
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
            ClientSize = new Size(1009, 520);
            Controls.Add(btnAddPic);
            Controls.Add(dgvPictures);
            Controls.Add(btnNextImage);
            Controls.Add(btnLastImage);
            Controls.Add(pictureBox1);
            Name = "frmImages";
            Text = "Images";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPictures).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLastImage;
        private Button btnNextImage;
        private DataGridView dgvPictures;
        private Button btnAddPic;
    }
}