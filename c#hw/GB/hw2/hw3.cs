using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw2
{
    class hw3
    {
        public static void GetallPisitiveNumbers()
        {
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int summ = 0;
            while (num != 0)
            {
                if (num > 0 & !(num % 2 == 0))
                {
                    summ += num;
                }
                Console.WriteLine("Введите число: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("All positive numbers: " + summ);
        }
    }
}
