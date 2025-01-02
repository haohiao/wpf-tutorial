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

namespace ToolBarControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeCommandBinding();
        }

        public void InitializeCommandBinding()
        {
            var finalCanExecute = new CanExecuteRoutedEventHandler((sender, e) => e.CanExecute = true);

            CommandBinding newCommandBinding = new(ApplicationCommands.New);
            newCommandBinding.CanExecute += finalCanExecute;
            CommandBinding openCommandBinding = new(ApplicationCommands.Open);
            openCommandBinding.CanExecute += finalCanExecute;
            CommandBinding saveCommandBinding = new(ApplicationCommands.Save);
            saveCommandBinding.CanExecute += finalCanExecute;

            CommandBindings.AddRange(new[] { newCommandBinding, openCommandBinding, saveCommandBinding });
        }
    }
}