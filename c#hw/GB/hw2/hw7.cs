using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw2
{
    class hw7
    {
        public static int RecusiveNumbers(int a, int b, int result = 0)
        {
            if (a > b) return RecusiveNumbers(a, b);
            if (a == b) return a;
            Console.WriteLine(a + b);
            return a + RecusiveNumbers(a + 1, b);
        }
    }
}
