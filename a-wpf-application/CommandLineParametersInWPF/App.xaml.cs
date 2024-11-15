using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace CommandLineParametersInWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            string path = e.Args[0];

            MainWindow mainWindow = new MainWindow();
            mainWindow.textbolock.Text = $"lines: {File.ReadAllLines(path).Length}";
            mainWindow.Show();
        }
    }

}
