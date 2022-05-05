using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw3
{
    class hw2
    {
        public static void FindToZero()
        {
            int result = 0, num = 0;
            do
            {
                Console.WriteLine("Введите число: ");
                int.TryParse(Console.ReadLine(), out num);
                if (num % 2 == 0)
                {
                    result += num;
                }
            }
            while (num != 0);
            Console.WriteLine(result);
        }
    }
}
