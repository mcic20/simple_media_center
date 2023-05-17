namespace simple_media_center.Data
{
    public class DataPath
    {
        public string PathData { get; set; }

        public string GetPath(string a)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(_filePath).FullName;
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += $"\\{a}.txt";
            return _filePath;
        }
    }
}
