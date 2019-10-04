using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Reproductor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Reproductor.Play();
        }
        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            Reproductor.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            Reproductor.Stop();
        }

        private void Trailer1RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Reproductor.Source = new Uri("C:/Users/alumno/Desktop/trailers/trailer1.mp4");
            Reproductor.Play();
        }

        private void Trailer2RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Reproductor.Source = new Uri("C:/Users/alumno/Desktop/trailers/trailer2.mp4");
            Reproductor.Play();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Reproductor.IsMuted = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Reproductor.IsMuted = false;
        }
    }
}
