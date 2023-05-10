﻿using Microsoft.Win32;
using System;
using System.Windows;


namespace Video_sound
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        bool ISPLAYING;
        public MainWindow()
        {
            InitializeComponent();
            txtVolume.Text = "";
            sliderVolume.Value = 5;
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Videos|*.mp4; *.mkv; *.webm; *.avi";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            try
            {
                elementVideo.Source = new Uri(ofd.FileName);
                ISPLAYING = true;
                btnPlay.Content = "||";
            }
            catch
            {

            }


        }

        private void sliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            elementVideo.Volume = sliderVolume.Value;
            txtVolume.Text = ((sliderVolume.Value) * 10).ToString();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (elementVideo.Source != null)
            {
                if (ISPLAYING)
                {
                    elementVideo.SpeedRatio = 0;
                    ISPLAYING = false;
                    btnPlay.Content = ">";
                }
                else
                {
                    elementVideo.SpeedRatio = 1;
                    ISPLAYING = true;
                    btnPlay.Content = "||";
                }
            }
        }

        private void windowVideo_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if(e.Delta > 0)
            {
                elementVideo.Volume = sliderVolume.Value+1;
                txtVolume.Text = ((sliderVolume.Value) * 10).ToString();
            }
            else
            {
                elementVideo.Volume = sliderVolume.Value - 1;
                txtVolume.Text = ((sliderVolume.Value) * 10).ToString();
            }
        }

        private void Grid_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                elementVideo.Volume = sliderVolume.Value + 1;
                txtVolume.Text = ((sliderVolume.Value) * 10).ToString();
            }
            else
            {
                elementVideo.Volume = sliderVolume.Value - 1;
                txtVolume.Text = ((sliderVolume.Value) * 10).ToString();
            }
        }
    }
}
