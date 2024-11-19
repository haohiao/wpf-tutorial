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

namespace TextBoxControl
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

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox inputTextBox = sender as TextBox;
            statusTextBox.Text = "Selection starts at character #" + inputTextBox.SelectionStart + Environment.NewLine;
            statusTextBox.Text += "Selection is " + inputTextBox.SelectionLength + " character(s) long" + Environment.NewLine;
            statusTextBox.Text += "Selected text: '" + inputTextBox.SelectedText + "'";
        }
    }
}