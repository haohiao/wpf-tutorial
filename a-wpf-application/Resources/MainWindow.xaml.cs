using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Resources
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ExampleWindow1 exampleWindow1 = new ExampleWindow1();
            exampleWindow1.Show();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ExampleWindow2 exampleWindow2 = new ExampleWindow2();
            exampleWindow2.Show();
        }
    }
}