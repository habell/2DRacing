﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw1
{
    class hw5_6
    {
        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        public static void Pause()
        {
            Console.ReadLine();
        }
    }
}
