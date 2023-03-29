using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectConsole
{
    class Windows
    {
        public static void MainMenu()
        {
            int x = 10;
            int y = 10;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("〓〓〓〓〓 Fate / Another 〓〓〓〓〓");
            Console.SetCursorPosition(++x, ++y);
            Console.WriteLine("1. New Game");
            Console.SetCursorPosition(x, ++y);
            Console.WriteLine("2. Load Game");
            Console.SetCursorPosition(x, ++y);
            Console.WriteLine("3. Options");
            Console.SetCursorPosition(x, ++y);
            Console.WriteLine("4. Quit");
        }
    }
}
