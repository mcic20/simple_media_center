using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Video_sound.Classes;
using Video_sound.Repository;

namespace Video_sound
{
    /// <summary>
    /// Interaction logic for Music.xaml
    /// </summary>
    public partial class Music : Window
    {
        bool ISPLAYING;
        public Music()
        {
            InitializeComponent();
            MusicRepository musicRepository = new();
            try
            {
                dgvMusic.ItemsSource = musicRepository.GetMusic();
            }
            catch {

                System.Windows.MessageBox.Show("Error in reading MusicPaths file. Please delete data from that file.");
            }
            txtVolume.Text = "";
            sliderVolumeMusic.Value = 5;
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            MusicRepository songRepository = new();
            songRepository.AddMusic();
            List<Song> songs = songRepository.GetMusic();
            dgvMusic.ItemsSource = songs;
        }

        private void sliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            elementMusic.Volume = sliderVolumeMusic.Value;
            txtVolume.Text = ((sliderVolumeMusic.Value) * 10).ToString();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (elementMusic.Source != null)
            {
                if (ISPLAYING)
                {
                    elementMusic.SpeedRatio = 0;
                    btnPlayMusic.Content = ">";
                    ISPLAYING = false;
                }
                else
                {
                    elementMusic.SpeedRatio = 1;
                    ISPLAYING = true;
                    btnPlayMusic.Content = "||";
                }
            }
            else
            {
                try
                {
                    Song song = new();
                    song = dgvMusic.SelectedItem as Song;
                    elementMusic.Source= new Uri(song.MusicPath);
                    txtSong.Text = song.Name;
                }
                catch {

                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Song song = new();
            song = dgvMusic.SelectedItem as Song;
           if (song != null) { 
                string del = $"{song.Name};{song.MusicPath}";
                MusicRepository musicRepository = new ();
                musicRepository.DeleteSelected(del);
                dgvMusic.ItemsSource = musicRepository.GetMusic();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            MusicRepository songRepository = new();
            songRepository.DeleteAll();
            dgvMusic.ItemsSource = songRepository.GetMusic();
        }

        private void elementMusic_MediaOpened(object sender, RoutedEventArgs e)
        {
            sliderMusic.Maximum = elementMusic.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void sliderMusic_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int SliderValue = (int)sliderMusic.Value;
            TimeSpan ts = new (0, 0, 0, SliderValue, 0);
            elementMusic.Position = ts;
        }
    }
}
