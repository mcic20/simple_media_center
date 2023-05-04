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
    }
}