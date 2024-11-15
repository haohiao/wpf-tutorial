using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Resources
{
    /// <summary>
    /// ExampleWindow2.xaml 的交互逻辑
    /// </summary>
    public partial class ExampleWindow2 : Window
    {
        public ExampleWindow2()
        {
            InitializeComponent();
        }

        private void BrushComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            LinearGradientBrush[] brushs = (LinearGradientBrush[])Resources["BackgroundBrushs"];

            Resources["WindowBackgroundBrush"] = brushs[BrushComboBox.SelectedIndex];
        }
    }
}
