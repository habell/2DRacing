using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworks3
{
    // Lesson 3
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

        public static int FindToZero()
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
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(1, 1);
            Complex c2 = new Complex(1, 2);

            Complex res = c.Plus(c2);
            Console.WriteLine($"Res: R={res.Re} Im={res.Im}");
            Console.WriteLine(Complex.FindToZero());
            Console.ReadKey();
        }
    }
}
