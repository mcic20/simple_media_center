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
            MusicRepository musicRepository = new MusicRepository();
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
            MusicRepository songRepository = new MusicRepository();
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
                    Song song = new Song();
                    song = dgvMusic.SelectedItem as Song;
                    elementMusic.Source= new Uri(song.MusicPath);
                    txtSong.Text = song.Name;
                }
                catch {

                }
            }
        }
    }
}
