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

namespace RichTextBoxControl
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

        private void GetTextButton_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(Editor.Document.ContentStart, Editor.Document.ContentEnd);
            MessageBox.Show(textRange.Text);
        }

        private void SetTextButton_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(Editor.Document.ContentStart, Editor.Document.ContentEnd);
            textRange.Text = "Another world, another text!";
        }

        private void GetSelectTextButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Editor.Selection.Text);
        }

        private void SetSelectTextButton_Click(object sender, RoutedEventArgs e)
        {
            Editor.Selection.Text = "[Replaced text]";
        }

        private void Editor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(Editor.Document.ContentStart, Editor.Selection.Start);
            StatusTextBox.Text =
                $"""
                Selection starts at character #{textRange.Text.Length + 1}
                Selection is {Editor.Selection.Text.Length} characters long
                Selected text: '{Editor.Selection.Text}'
                """;
        }
    }
}