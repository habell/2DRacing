using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw1
{
    class hw4
    {
        public static void SwapXY()
        {
            int x = 21;
            int y = 221;
            int z = 0;
            Console.WriteLine($"x: {x} y: {y} Press any key if you need to change x and y.");
            Console.ReadLine();

            z = x;
            x = y;
            y = z;

            Console.WriteLine($"x: {x} y: {y} Press any key if you need to change x and y.");
            Console.ReadLine();

            (x, y) = (y, x);
            Console.WriteLine($"x: {x} y: {y}");
        }
    }
}
