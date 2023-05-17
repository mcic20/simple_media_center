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
            OpenFileDialog ofd = new()
            {
                Filter = "Music|*.mp3; *.flac; *.wav",
                Multiselect = false
            };
            ofd.ShowDialog();
            Song music = new()
            {
                MusicPath = ofd.FileName,
                Name = ofd.SafeFileName
            };
            string newMusic = $"{music.Name};{music.MusicPath}";
            MusicPath dataPath = new();
            File.AppendAllText(dataPath.GetPath("MusicPaths"), newMusic + Environment.NewLine);
        }
        public List<Song> GetMusic()
        {
            List<Song> songs = new();
            MusicPath dataPath = new();
            try
            {
                StreamReader sr = new (dataPath.GetPath("MusicPaths"));
                var lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var column1 = new List<string>();
                var column2 = new List<string>();
                foreach (var line in lines)
                {
                    Song music = new();
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
                return songs;
            }
        }
        public void DeleteAll()
        {
            MusicPath dataPath = new();
            File.WriteAllText(dataPath.GetPath("MusicPaths"), "");
        }

        public void DeleteSelected(string a)
        {
            MusicPath dataPath = new();
            string str = File.ReadAllText(dataPath.GetPath("MusicPaths"));
            string str2 = "";
            str = str.Replace(a, str2);
            File.WriteAllText(dataPath.GetPath("MusicPaths"), str);
        }
    }
}

