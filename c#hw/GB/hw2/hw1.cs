using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw2
{
    class hw1
    {
        public static int GetMinNum(int x, int y, int z)
        {
            if (x < y & x < z) return x;
            if (y < x & y < z) return y;
            return z;
        }
    }
}
