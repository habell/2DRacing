using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw3
{
    struct Complex
    {
        public double Im { get; private set; }
        public double Re { get; private set; }
        public Complex(double im, double re)
        {
            Im = im;
            Re = re;
        }
        public Complex Plus(Complex other)
        {
            var complex = new Complex();
            complex.Im = other.Im + Im;
            complex.Re = other.Re + Re;
            return complex;
        }
        public Complex Minus(Complex other)
        {
            var complex = new Complex();
            complex.Im = other.Im - Im;
            complex.Re = other.Re - Re;
            return complex;
        }
    }
    class hw1
    {
        public static void DemoComplex()
        {
            Complex c = new Complex(1, 1);
            Complex c2 = new Complex(1, 2);

            Complex res = c.Plus(c2);
            Console.WriteLine($"Res: R={res.Re} Im={res.Im}");
        }
    }
}
