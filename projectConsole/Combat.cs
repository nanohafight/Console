using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace projectConsole
{
    public static class Combat
    {
        static void CharacterRender(Player player)
        {
            Console.SetCursorPosition(player.x, player.y);
            Console.Write("♥");
            while (true)
            {
                ConsoleKeyInfo key;
                int tempX = player.x;
                int tempY = player.y;
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    player.y--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    player.y++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    player.x--;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    player.x++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Windows.ESCMenu(player);
                }
                    Console.SetCursorPosition(tempX, tempY);
                
                Console.Write("  ");
                Console.SetCursorPosition(player.x, player.y);
                Console.Write("♥");
            }
        }

        public static void Combat_1(Player player)
        {
            Console.Clear();
            Windows.MainMapRender();
            CharacterRender(player);
            
        }
    }
}

