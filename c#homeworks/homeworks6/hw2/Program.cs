using System;
using System.Collections.Generic;
using System.IO;
namespace hw2
{

    public delegate double func(double x);
    class Program
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return x * x - 50 * x + x * x - 50 * x + 10;
        }
        public static void SaveFunc(func f, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,
            FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static List<double> Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            List<double> l = new List<double>();
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                l.Add(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return l;
        }
        
        static void Main(string[] args)
        {
            List<func> f = new List<func>();
            f.Add(F);
            f.Add(F2);
            f.Add(Math.Cos);
            f.Add(Math.Sin);
            double min;
            List<double> l;
            bool tr = true;
            Console.WriteLine("Введите число от 1 до 4 копка Q - выход");
            while (tr)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        SaveFunc(f[0], "data.bin", -100, 100, 0.5);
                        continue;
                    case ConsoleKey.D2:
                        SaveFunc(f[1], "data.bin", -100, 100, 0.5);
                        continue;
                    case ConsoleKey.D3:
                        SaveFunc(f[2], "data.bin", -100, 100, 0.5);
                        continue;
                    case ConsoleKey.D4:
                        SaveFunc(f[3], "data.bin", -100, 100, 0.5);
                        continue;
                    case ConsoleKey.Q: 
                        tr = false;
                        break;
                }
                l = Load("data.bin", out min);
                Console.WriteLine(min);
            }
            Console.ReadKey();
        }
    }
}
