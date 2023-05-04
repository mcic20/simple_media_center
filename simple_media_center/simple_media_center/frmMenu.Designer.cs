namespace simple_media_center
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            label1 = new Label();
            btnVideo = new Button();
            btnMusic = new Button();
            btnPhotos = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(110, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(564, 39);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to simple_media_center";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(272, 94);
            label1.Name = "label1";
            label1.Size = new Size(235, 28);
            label1.TabIndex = 1;
            label1.Text = "What do you want to do?";
            // 
            // btnVideo
            // 
            btnVideo.Location = new Point(333, 157);
            btnVideo.Name = "btnVideo";
            btnVideo.Size = new Size(132, 51);
            btnVideo.TabIndex = 2;
            btnVideo.Text = "Watch video";
            btnVideo.UseVisualStyleBackColor = true;
            // 
            // btnMusic
            // 
            btnMusic.Location = new Point(333, 256);
            btnMusic.Name = "btnMusic";
            btnMusic.Size = new Size(132, 51);
            btnMusic.TabIndex = 3;
            btnMusic.Text = "Play audio";
            btnMusic.UseVisualStyleBackColor = true;
            // 
            // btnPhotos
            // 
            btnPhotos.Location = new Point(333, 358);
            btnPhotos.Name = "btnPhotos";
            btnPhotos.Size = new Size(132, 51);
            btnPhotos.TabIndex = 4;
            btnPhotos.Text = "Open photos";
            btnPhotos.UseVisualStyleBackColor = true;
            btnPhotos.Click += btnPhotos_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPhotos);
            Controls.Add(btnMusic);
            Controls.Add(btnVideo);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "simple_media_center";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label label1;
        private Button btnVideo;
        private Button btnMusic;
        private Button btnPhotos;
    }
}