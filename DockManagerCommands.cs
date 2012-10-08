using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace XamDockManager.NewTabButton
{
    class DockManagerCommands
    {
        private static RoutedUICommand _newTab;

        public static RoutedUICommand NewTab { get { return _newTab; } }

        static DockManagerCommands()
        {
            _newTab = new RoutedUICommand("New Tab", "NewTab", typeof(DockManagerCommands));
        }
    }
}
