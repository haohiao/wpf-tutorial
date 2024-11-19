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

namespace CheckBoxControl
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

        private void AllFeaturesCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            FeatureAbcCheckBox.IsChecked =
            FeatureXyzCheckBox.IsChecked =
            FeatureWwwCheckBox.IsChecked =
                AllFeaturesCheckBox.IsChecked == true;
        }

        private void FeatureCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            AllFeaturesCheckBox.IsChecked = null;
            if (FeatureAbcCheckBox.IsChecked == true && 
                FeatureXyzCheckBox.IsChecked == true && 
                FeatureWwwCheckBox.IsChecked == true)
            {
                AllFeaturesCheckBox.IsChecked = true;
            }
            if (FeatureAbcCheckBox.IsChecked == false &&
                FeatureXyzCheckBox.IsChecked == false &&
                FeatureWwwCheckBox.IsChecked == false)
            {
                AllFeaturesCheckBox.IsChecked = false;
            }
        }
    }
}