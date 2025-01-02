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

namespace StatusBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            GetCursorPosition();
        }

        private void GetCursorPosition()
        {
            int row = Editor.GetLineIndexFromCharacterIndex(Editor.CaretIndex);
            int col = Editor.CaretIndex - Editor.GetCharacterIndexFromLineIndex(row);
            CursorPositionTextBlock.Text = "Line " + (row + 1) + ", Char " + (col + 1);
        }

        private void Editor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            GetCursorPosition();
        }
    }
}