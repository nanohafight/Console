using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectConsole
{
    public static class Combat
    {
        public static void Combat_1()
        {
            int aX = 5, aY = 10;            
            while (true)
            {
                ConsoleKeyInfo key;
                int tempX = aX;
                int tempY = aY;
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    aY--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    aY++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    aX--;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    aX++;
                }
                Console.SetCursorPosition(tempX, tempY);
                Console.Write("  ");
                Console.SetCursorPosition(aX, aY);
                Console.Write("♥");
            }
            }
        }
    }

