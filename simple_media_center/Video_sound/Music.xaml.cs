using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Video_sound.Classes;
using Video_sound.Repositories;

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
            txtVolumeMusic.Text = "";
            sliderVolumeMusic.Value = 5;
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Music|*.mp3; *.flac; *.wav; *.mp4";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            try
            {
                elementMusic.Source = new Uri(ofd.FileName);
                txtSong.Text = ofd.SafeFileName;
                ISPLAYING = true;
                btnPlayMusic.Content = "||";
            }
            catch
            {

            }
        }

        private void sliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            elementMusic.Volume = sliderVolumeMusic.Value;
            txtVolumeMusic.Text = ((sliderVolumeMusic.Value) * 10).ToString();
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
        }
    }
}
