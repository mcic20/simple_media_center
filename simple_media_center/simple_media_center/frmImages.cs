using simple_media_center.Classes;
using simple_media_center.Repositories;

namespace simple_media_center
{
    public partial class frmImages : Form
    {
        public frmImages()
        {
            InitializeComponent();
            PictureRepository pictureRepository = new PictureRepository();
            List<Picture> pictures = pictureRepository.GetPictures();
            dgvPictures.DataSource = pictures;
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            PictureRepository pictureRepository = new PictureRepository();
            pictureRepository.GetFile();
            List<Picture> pictures = pictureRepository.GetPictures();
            dgvPictures.DataSource = pictures;
        }

        private void dgvPictures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPictures.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string path = dgvPictures.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    pictureBox1.ImageLocation = path;
                }
            }
            catch
            {

            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            Hide();
            frmMenu.ShowDialog();
            Close();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            PictureRepository pictureRepository = new PictureRepository();
            pictureRepository.DeleteAll();
            pictureBox1.Image = null;
            List<Picture> pictures = pictureRepository.GetPictures();
            dgvPictures.DataSource = pictures;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string path = dgvPictures.SelectedCells[0].Value.ToString();
            PictureRepository pictureRepository2 = new PictureRepository();
            pictureRepository2.DeleteSelected(path);
            List<Picture> pictures = pictureRepository2.GetPictures();
            dgvPictures.DataSource = pictures;
        }
    }
}
