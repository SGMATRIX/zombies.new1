using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace Zombies
{
    class WpfConsole
    {
        private TextBox Console;
        public WpfConsole(TextBox consoleTextBox)
        {
            Console = consoleTextBox;
        }

        public void WriteLine(string text, SolidColorBrush color)
        {
            Console.Text += $"\n[{DateTime.Now:T}] {text}";
            Console.Foreground = color;
            Console.ScrollToEnd();
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
