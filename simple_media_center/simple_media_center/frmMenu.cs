namespace simple_media_center
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            frmImages images = new frmImages();
            Hide();
            images.ShowDialog();
            Close();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Video_sound.MainWindow mainWindow = new Video_sound.MainWindow();
            Hide();
            mainWindow.ShowDialog();
            Close();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            Video_sound.Music mainWindow = new Video_sound.Music();
            Hide(); 
            mainWindow.ShowDialog();
            Close();
        }
    }
}