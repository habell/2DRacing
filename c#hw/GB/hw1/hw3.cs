using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw1
{
    class hw3
    {
        public static double math_sqrtFunct(double x1, double x2, double y1, double y2) // расчет расстояния
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
    }
}
