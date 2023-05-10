using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            File.AppendAllText("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\Video_sound\\Data\\MusicPaths.txt", newMusic + Environment.NewLine);
        }
        public List<Song> GetMusic()
        {
            List<Song> songs = new List<Song>();
            StreamReader sr = new StreamReader("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\Video_sound\\Data\\MusicPaths.txt");
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
    }
}

