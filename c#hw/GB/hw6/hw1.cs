using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw6
{

    class hw1
    {
        public delegate double Fun(double x);
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double x)
        {
            return x * x * x;
        }
        public static void Main()
        {

            Console.WriteLine("Таблица функции MyFunc:");

            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");

            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2); 
            Console.WriteLine("Таблица функции x^2:");

            Table(delegate (double x) { return x * x; }, 0, 3);
        }
    }
}
