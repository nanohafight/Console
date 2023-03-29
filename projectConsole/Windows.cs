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
            while(true)
            {
                ConsoleKeyInfo key;
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
                key = Console.ReadKey(true);
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.D1 : MainMap(); break;
                    case ConsoleKey.D4 : Environment.Exit(0); break;
                    default: continue;
                }
                break;      
            }
        }

        static void MainMap()
        {
            while(true)
            {
                Console.Clear();
                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        if (i == 20 && j != 0 && j != 49)
                        {
                            Console.Write("〓");
                        }
                        else if (i == 0 || i == 29 || j == 0 || j == 49)
                        {
                            Console.Write("■");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1: Combat.Combat_1(); break;
                    default: continue;
                }
            }
        }

          
    }
}
