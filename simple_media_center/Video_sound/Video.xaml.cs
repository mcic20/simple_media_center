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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Videos|*.mp4; *.mkv; *.webm; *.avi";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            try {
                elementVideo.Source = new Uri(ofd.FileName);
            }
            catch
            {

            }
        }
    }
}
