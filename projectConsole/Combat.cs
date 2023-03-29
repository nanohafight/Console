using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectConsole
{
    class Combat
    {
        public void Fight()
        {
            ConsoleKeyInfo key;
            int playerX = 5, playerY = 10;
            //int enemyX = 1, enemyY = 5;
            //int playerHp = 10;

            while (true)
            {
                key = Console.ReadKey(true);
                Console.Clear();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    playerY--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    playerY++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    playerX--;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    playerX++;
                }

                Console.SetCursorPosition(playerX, playerY);
                Console.Write("♥");
            }
        }
    }
}
