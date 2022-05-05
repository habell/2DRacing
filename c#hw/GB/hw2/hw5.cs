using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw2
{
    class hw5
    {
        public static string GetMassIndex(double w, double h)
        {
            h = h / 100;
            double result = w / (h * h);
            string wHard = "You are overweight! You need to lose weight by: ";
            string wLow = "You are underweight! You need to get better by: ";
            string wReturn = "You don't have a weight problem!";
            switch (result)
            {
                case < 18:
                    wReturn = howNeed(wLow, result, h);
                    break;
                case > 25:
                    wReturn = howNeed(wHard, result, h);
                    break;
                default:
                    //wReturn = wReturn;
                    break;
            }
            return wReturn;
        }

        private static string howNeed(string weightInfo, double res, double h, bool normal = false)
        {
            if (!normal)
            {
                res = (int)(res < 18 ? (18 - res) * h : (res - 25) * h);
                weightInfo = weightInfo + res + " kg";
            }
            return weightInfo;
        }
    }
}
