﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace projectConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(102, 31);
            Console.SetBufferSize(102, 31);
            Player saber = new Player("Saber", 3800, 2350);
            Windows.MainMenu(saber);


        }
    }
}
