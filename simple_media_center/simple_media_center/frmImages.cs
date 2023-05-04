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
            dgvPictures.Refresh();
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
    }
}
