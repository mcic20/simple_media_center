using Microsoft.VisualBasic.ApplicationServices;
using simple_media_center.Classes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace simple_media_center.Repositories
{
    public class PictureRepository
    {
        public void GetFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pictures|*.png";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            Picture picture = new Picture();
            picture.Path = ofd.FileName;
            picture.Name = ofd.SafeFileName;
            string newPic = $"{picture.Name} ; {picture.Path}";
            File.AppendAllText("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt", newPic + Environment.NewLine);
        }
    }
}
