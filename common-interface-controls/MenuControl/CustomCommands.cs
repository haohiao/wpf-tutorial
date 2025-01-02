using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MenuControl
{
    internal static class CustomCommands
    {
        public static readonly RoutedUICommand Enlargement = new RoutedUICommand
            (
                "Enlargement",
                "Enlargement",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.E, ModifierKeys.Control)
                }
            );
    }
}
