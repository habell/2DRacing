using System;

namespace GB
{
    class Program
    {
        private static void PrintHWData()
        {
            Console.WriteLine("Хаблиев");
        }

        private static void CheckHomeworks_1() 
        {
            hw1.hw1.Anketa();

            hw1.hw2.HumanBodyIndex();

            Console.WriteLine($"Расстояние между точками с координатами x1, y1 и x2,y2: {hw1.hw3.math_sqrtFunct(1000, 10, 100, 50):f2} \n\n");

            hw1.hw4.SwapXY();

            hw1.hw5_6.Print("Тимур Хаблиев, Владикавказ", 40, 10);
            hw1.hw5_6.Pause();
        }

        private static void CheckHomeworks_2()
        {
            var result = hw2.hw1.GetMinNum(7, 5, 8);
            Console.WriteLine(result);

            hw2.hw2.GetAllNumbers(21412);

            hw2.hw3.GetallPisitiveNumbers();

            hw2.hw4.SignIn("TestLogin", "TestPass");

            var reshw5 = hw2.hw5.GetMassIndex(100, 180);
            Console.WriteLine(reshw5);

            var reshw6 = hw2.hw6.GoodNumbers(100000);
            Console.WriteLine(reshw6);

            var reshw7 = hw2.hw7.RecusiveNumbers(0, 100);
            Console.WriteLine(reshw7);
        }

        private static void CheckHomeworks_3()
        {
            hw3.hw1.DemoComplex();

            hw3.hw2.FindToZero();
        }

        private static void CheckHomeworks_4()
        {
            hw4.hw1_2_3.DemoHW4_123();

            hw4.hw4.DemoLogin();
        }

        private static void CheckHomeworks_5()
        {
            hw5.hw1.LogPassHW();

            var str = "Слово В Котором есть какие-то символы требует расчленения";
            hw5.Message.homework_a(str, 5);
            Console.WriteLine(hw5.Message.homework_b(str, 'о'));
            Console.WriteLine(hw5.Message.homework_c(str));


        }
        static void Main(string[] args)
        {
            PrintHWData();
            //CheckHomeworks_1();
            //CheckHomeworks_2();
            //CheckHomeworks_3();
            //CheckHomeworks_4();
            CheckHomeworks_5();

        }
    }
}
