using simple_media_center.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_media_center
{
    public partial class frmImages : Form
    {
        public frmImages()
        {
            InitializeComponent();
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            PictureRepository pictureRepository = new PictureRepository();
            pictureRepository.GetFile();

        }
    }
}
