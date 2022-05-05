using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw2
{
    class hw2
    {
        public static void GetAllNumbers(int num)
        {
            int numbers = 0;
            while (num > 0)
            {
                numbers++;
                num = num / 10;
            }
            Console.WriteLine("Numbers count is: " + numbers);
        }
    }
}
