using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;


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

        private void elementVideo_MediaOpened(object sender, RoutedEventArgs e)
        {
            sliderTimeline.Maximum = elementVideo.NaturalDuration.TimeSpan.TotalSeconds;
            txtDuration.Text = sliderTimeline.Maximum.ToString();
            txtCurrentTime.Text = elementVideo.Position.TotalSeconds.ToString();
        }

        private void sliderTimeline_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int SliderValue = (int)sliderTimeline.Value;
            TimeSpan ts = new TimeSpan(0, 0, 0, SliderValue, 0);
            elementVideo.Position = ts;
            txtCurrentTime.Text = elementVideo.Position.TotalSeconds.ToString();
        }
    }
}
