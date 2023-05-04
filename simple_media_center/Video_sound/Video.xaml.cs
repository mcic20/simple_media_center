using Microsoft.Win32;
using System;
using System.Windows;

namespace Video_sound
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
    }
}
