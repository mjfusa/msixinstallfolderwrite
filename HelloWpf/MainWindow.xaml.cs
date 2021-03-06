using System;
using System.Collections.Generic;
using System.IO;
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
using Windows.ApplicationModel;
using Windows.Devices.Geolocation;

namespace HelloWpf
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //tbVersion.Text = $"{Package.Current.Id.Version.Major}.{Package.Current.Id.Version.Minor}.{Package.Current.Id.Version.Build}.{Package.Current.Id.Version.Revision}";

            try
            {
                File.WriteAllText("\\ProgramData\\out.txt", "this is a test");
            } catch ( Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var p = Package.Current.InstalledLocation.Path;
            File.WriteAllText(p + "\\installfolder.txt", "this is a test");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var p = Package.Current.InstalledLocation.Path;
            var text= File.ReadAllText(p + "\\installfolder.txt");
            tbLocation.Text = text;
        }
    }
}
