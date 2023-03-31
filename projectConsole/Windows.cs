using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace projectConsole
{
    class Windows
    {
        public static void MainMenu(Player player)
        {
            while (true)
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
                    case ConsoleKey.D1: MainMapSelect(player); break;
                    case ConsoleKey.D4: Environment.Exit(0); break;
                    default: continue;
                }
                break;
            }
        }

        public static void MainMapRender()
        {
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
        }
        public static void ESCMenu(Player player)
        {
            while (true)
            {
                Console.Clear();
                MainMapRender();
                Console.SetCursorPosition(12, 22);
                Console.WriteLine("1. 스킬 사용");

                Console.SetCursorPosition(12, 24);
                Console.WriteLine("2. 아이템 사용");
                Console.SetCursorPosition(12, 26);
                Console.WriteLine("3. 게임 종료");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.D1: SelectSkill(player); break;
                    case ConsoleKey.D2: Inventory(player); break;
                    case ConsoleKey.D3: Environment.Exit(0); break;
                    default: continue;
                }
                break;
            }
        }

        public static void SelectSkill(Player player)
        {
            
        }
        public static void Inventory(Player player)
        {

        }


        public static void MainMapSelect(Player player)
        {
            while (true)
            {
                Console.Clear();
                MainMapRender();
                Console.SetCursorPosition(5, 5);
                Console.Write("1. 류도사");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1: Combat.Combat_1(player); break;
                    default: break;
                }
            }
        }



    }
}



    

