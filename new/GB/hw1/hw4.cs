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
            int x = 5;
            int y = 10;
            int z = 0;
            Console.WriteLine($"x: {x} y: {y} Нажмите Enter что-бы х и у поменялись местами.");
            Console.ReadLine();

            z = x;
            x = y;
            y = z;

            Console.WriteLine($"x: {x} y: {y} Нажмите Enter что-бы заменить х и у местами ещё раз, другим методом.");
            Console.ReadLine();

            (x, y) = (y, x);
            Console.WriteLine($"x: {x} y: {y}");
        }
    }
}
