using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WorkingWithApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Icon = new BitmapImage(new Uri("pack://application:,,,/R.ico"));
            mainWindow.Show();
        }
    }

}
