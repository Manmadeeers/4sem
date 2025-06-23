using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SoftwareShop.Views
{
    public static class MyCommands
    {
        public static readonly RoutedUICommand DoSomethingCommand = new RoutedUICommand(
            "Do Something", "DoSomething", typeof(MyCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.D, ModifierKeys.Control)
            });
    }
}
