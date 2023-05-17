using simple_media_center.Classes;
using simple_media_center.Data;

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
            DataPath dataPath = new DataPath();
            File.AppendAllText(dataPath.GetPath("PicturePaths"), newPic + Environment.NewLine);
        }

        public List<Picture> GetPictures()
        {
            List<Picture> pictures = new List<Picture>();
            DataPath dataPath = new DataPath();
            try
            {
                StreamReader sr = new StreamReader(dataPath.GetPath("PicturePaths"));
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
            catch {
                pictures = null;
                return pictures;
                    }
        }

        public void DeleteAll()
        {
            DataPath dataPath = new DataPath();
            File.WriteAllText(dataPath.GetPath("PicturePaths"), "");
        }

        public void DeleteSelected(string a)
        {
            DataPath dataPath = new DataPath();
            string str = File.ReadAllText(dataPath.GetPath("PicturePaths"));
            string str2 = "";
            str = str.Replace(a, str2);
            File.WriteAllText(dataPath.GetPath("PicturePaths"), str);
        }
    }
}
