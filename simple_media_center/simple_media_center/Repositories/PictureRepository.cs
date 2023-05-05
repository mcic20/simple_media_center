using simple_media_center.Classes;

namespace simple_media_center.Repositories
{
    public class PictureRepository
    {
        public void GetFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pictures|*.png; *.jpeg; *.jpg";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            Picture picture = new Picture();
            picture.Path = ofd.FileName;
            string newPic = $"{picture.Path}";
            File.AppendAllText("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt", newPic + Environment.NewLine);
        }

        public List<Picture> GetPictures()
        {
            List<Picture> pictures = new List<Picture>();
            StreamReader sr = new StreamReader("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt");
            var lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                Picture picture = new Picture();
                picture.Path = line;
                pictures.Add(picture);
            }
            sr.Close();
            return pictures;
        }

        public void DeleteAll() {
         File.WriteAllText("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt","");
        }
    }
}
