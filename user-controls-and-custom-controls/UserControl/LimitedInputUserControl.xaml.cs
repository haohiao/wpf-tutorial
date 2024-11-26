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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControl.UserControls
{
    /// <summary>
    /// LimitedInputUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class LimitedInputUserControl : System.Windows.Controls.UserControl
    {
        public LimitedInputUserControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        public required string Title { get; set; }
        public required string MaxLength { get; set; }
    }
}
