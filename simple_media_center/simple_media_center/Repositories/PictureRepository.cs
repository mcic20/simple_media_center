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

        public void DeleteAll()
        {
            File.WriteAllText("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt", "");
        }

        public void DeleteSelected(string a)
        {
            string str = File.ReadAllText("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt");
            int b = 0;
            StreamReader sr = new StreamReader("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt");
            var lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == a)
                {
                    b++;
                }
            }
            sr.Close();
            do
            {
                string str2 = "";
                str = str.Replace(a, str2);
                File.WriteAllText("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\simple_media_center\\Data\\PicturePaths.txt", str);
                b--;
            }
            while (b > 1);
        }
    }
}
