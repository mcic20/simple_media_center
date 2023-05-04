using Microsoft.VisualBasic.ApplicationServices;
using simple_media_center.Classes;
using System.Security.Cryptography;
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
            string newPic = $"{picture.Name};{picture.Path}";
            File.AppendAllText("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt", newPic + Environment.NewLine);
        }

        public List<Picture> GetPictures() {
            List <Picture> pictures = new List<Picture>();
            Picture picture = new Picture();
            StreamReader sr = new StreamReader("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt");
            var lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var values = line.Split(';');
                picture.Name += values[0];
                picture.Path = values[1];
            }
            pictures.Add(picture);
            return pictures;
        }
    }
}
