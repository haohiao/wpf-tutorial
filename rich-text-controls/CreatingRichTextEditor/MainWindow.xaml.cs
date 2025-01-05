using Microsoft.Win32;
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
using System.IO;
using IOPath = System.IO.Path;

namespace CreatingRichTextEditor
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
            #region 控件属性初始化
            FontFamilyComboBox.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            FontSizeComboBox.ItemsSource = new List<double> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            #endregion

            #region 命令初始化
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, Open_CanExcute, CanExecute));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, Save_CanExcute, CanExecute));
            #endregion
        }

        private void CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Open_CanExcute(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                TextRange range = new TextRange(Editor.Document.ContentStart, Editor.Document.ContentEnd);
                using (FileStream fs = new FileStream(dialog.FileName, FileMode.Open))
                {
                    if (IOPath.GetExtension(dialog.FileName).ToLower() == ".rtf")
                        range.Load(fs, DataFormats.Rtf);
                    else
                        range.Load(fs, DataFormats.Text);
                }
            }
        }

        private void Save_CanExcute(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                TextRange range = new TextRange(Editor.Document.ContentStart, Editor.Document.ContentEnd);
                using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                {
                    if (IOPath.GetExtension(dialog.FileName).ToLower() == ".rtf")
                        range.Save(fs, DataFormats.Rtf);
                    else
                        range.Save(fs, DataFormats.Text);
                }
            }
        }

        private void FontFamilyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontFamilyComboBox.SelectedItem != null)
            {
                Editor.Selection.ApplyPropertyValue(FontFamilyProperty, FontFamilyComboBox.SelectedItem);
            }
        }

        private void FontSizeComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FontSizeComboBox.SelectedItem != null)
            {
                Editor.Selection.ApplyPropertyValue(FontSizeProperty, FontSizeComboBox.SelectedItem);
            }
        }


        private void Editor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp;
            temp = Editor.Selection.GetPropertyValue(FontWeightProperty);
            BoldToggleButton.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = Editor.Selection.GetPropertyValue(FontStyleProperty);
            ItalicToggleButton.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = Editor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            UnderlineToggleButton.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = Editor.Selection.GetPropertyValue(FontFamilyProperty);
            FontFamilyComboBox.SelectedItem = temp;
            temp = Editor.Selection.GetPropertyValue(FontSizeProperty);
            FontSizeComboBox.SelectedItem = temp;
        }

        
    }
}