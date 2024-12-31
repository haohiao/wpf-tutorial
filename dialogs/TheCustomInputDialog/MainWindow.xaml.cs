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

namespace TheCustomInputDialog
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

        private void EnterNameButton_Click(object sender, RoutedEventArgs e)
        {
            CustomInputDialog dialog = new CustomInputDialog("Please enter your name:");
            dialog.Owner = this;
            if (dialog.ShowDialog() == true)
            {
                NameTextBlock.Text = dialog.Answer;
            }
        }
    }
}