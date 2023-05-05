using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Video_sound.Classes;

namespace Video_sound.Repositories
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
            string newMusic = $"{music.MusicPath}";
            File.AppendAllText("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\Video_sound\\Data\\MusicPaths.txt", newMusic);
        }
        public List<Song> GetMusic()
        {
            List<Song> songs = new List<Song>();
            StreamReader sr = new StreamReader("C:\\Users\\Mateo\\source\\repos\\simple_media_center\\simple_media_center\\Video_sound\\Data\\MusicPaths.txt");
            var lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                Song music = new Song();
                music.MusicPath = line;
                songs.Add(music);
            }
            sr.Close();
            return songs;
        }
    }
}

