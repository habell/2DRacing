using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw2
{
    class hw6
    {
        public static int GoodNumbers(int num)
        {
            DateTime start = DateTime.Now;
            int result = 0;
            while (num > 0)
            {
                int res = 0;
                int num2 = num;
                while (num2 > 0)
                {
                    res += num2 % 10;
                    num2 /= 10;
                }
                if (num % res == 0)
                {
                    result++;
                }
                num--;
            }
            DateTime finish = DateTime.Now;
            TimeSpan timeSpan = finish - start;
            Console.WriteLine($"Program running time: {timeSpan.TotalSeconds} sek.");
            return result;
        }
    }
}
