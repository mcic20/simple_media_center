using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Video_sound.Data;
using System.Windows.Forms;
using Video_sound.Classes;


namespace Video_sound.Repository
{
    public class MusicRepository
    {

        public void AddMusic()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Music|*.mp3; *.flac; *.wav";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            Song music = new Song();
            music.MusicPath = ofd.FileName;
            music.Name = ofd.SafeFileName;
            string newMusic = $"{music.Name};{music.MusicPath}";
            MusicPath dataPath = new MusicPath();
            File.AppendAllText(dataPath.GetPath("MusicPaths"), newMusic + Environment.NewLine);
        }
        public List<Song> GetMusic()
        {
            List<Song> songs = new List<Song>();
            MusicPath dataPath = new MusicPath();
            try
            {
                StreamReader sr = new StreamReader(dataPath.GetPath("MusicPaths"));
                var lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var column1 = new List<string>();
                var column2 = new List<string>();
                foreach (var line in lines)
                {
                    Song music = new Song();
                    var values = line.Split(";");
                    column1.Add(values[0]);
                    column2.Add(values[1]);
                    music.Name = column1.FirstOrDefault();
                    music.MusicPath = column2.FirstOrDefault();
                    songs.Add(music);
                }
                sr.Close();
                return songs;
            }
            catch
            {
                songs = null;
                return songs;
            }
        }
        public void DeleteAll()
        {
            MusicPath dataPath = new MusicPath();
            File.WriteAllText(dataPath.GetPath("MusicPaths"), "");
        }

        public void DeleteSelected(string a)
        {
            MusicPath dataPath = new MusicPath();
            string str = File.ReadAllText(dataPath.GetPath("MusicPaths"));
            string str2 = "";
            str = str.Replace(a, str2);
            File.WriteAllText(dataPath.GetPath("MusicPaths"), str);
        }
    }
}

