using System;

namespace GB
{
    class Program
    {
        private static void PrintHWData()
        {
            Console.WriteLine("Хаблиев");
        }
        static void Main(string[] args)
        {
            PrintHWData();

            hw1.hw1.Anketa();

            hw1.hw2.HumanBodyIndex();

            Console.WriteLine($"Расстояние между точками с координатами x1, y1 и x2,y2: {hw1.hw3.math_sqrtFunct(1000, 10, 100, 50):f2} \n\n");
            
            hw1.hw4.SwapXY();

            hw1.hw5_6.Print("Тимур Хаблиев, Владикавказ", 40, 10);
            hw1.hw5_6.Pause();
        }
    }
}
