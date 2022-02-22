using System;

namespace homeworks2
{
    class Program
    {

        static int GiveMin(int x, int y, int z)
        {
            if (x > y) if (y > z) return z;
            if (y > x) return x; else return y;
        }
         
        static int GiveNumbersCount(int num)
        {
            int numbers = 0;
            while (num > 0)
            {
                numbers++;
                num = num / 10;
            }
            return numbers;
        }

        static int FindNullAndSummPozitiveNumbers()
        {
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
            int summ = 0;
            while(num != 0)
            {
                if(num > 0 & !(num%2==0))
                {
                    summ += num;
                }
                Console.WriteLine("Введите число: ");
                num = int.Parse(Console.ReadLine());
            }
            return summ;
        }

        static string SignIn(string login, string pass)
        {
            int maxCount = 3; // макс количество попыток

            for (int i=maxCount; i > 0; i--)
            {
                Console.WriteLine("|| Авторизация ||");
                Console.WriteLine("Введите логин: ");
                string Login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                string Pass = Console.ReadLine();

                if (login == Login)
                {
                    if (Pass == pass)
                        return "Вы успешно авторизировались.";
                    else
                        Console.WriteLine("Вы ввели неверный пароль! Осталось попыток: " + (i-1));
                }
                else
                    Console.WriteLine("Вы ввели неверный логин! Осталось попыток: " + (i-1));
            }
            return "Ошибка авторизации!";
        }

        static string GetMassIndex(double w, double h)
        {
            h = h / 100;
            double result = w / (h * h);
            string wHard = "У вас излишний вес! Вам нужно похудеть на: ";
            string wLow = "У вас пониженный вес! Вам нужно поправиться на: ";
            string wReturn = "У вас нет проблем с весом!";
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

        static string howNeed(string weightInfo, double res, double h, bool normal = false)
        {
            if (!normal)
            {
                res = (int)(res < 18 ? (18 - res) * h : (res - 25) * h);
                weightInfo = weightInfo + res +" кг";
            }
            return weightInfo;
        }

        static int goodNumbers(int num)
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
            Console.WriteLine($"Время работы программы: {timeSpan.TotalSeconds} секунд.");
            return result;
        }

        static int RecusiveNumbers(int a, int b, int result = 0)
        {
            if (a > b) return RecusiveNumbers(a, b);
            if (a == b) return a;
            Console.WriteLine(a + b);
            return a + RecusiveNumbers(a+1, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GiveMin(103, 33, 11));              // Lesson 1

            Console.WriteLine(GiveNumbersCount(1023123));         // Lesson 2

            Console.WriteLine(FindNullAndSummPozitiveNumbers());  // Lesson 3

            Console.WriteLine(SignIn("root", "GeekBrains"));      // Lesson 4

            Console.WriteLine(GetMassIndex(100, 280));            // Lesson 5

            Console.WriteLine(goodNumbers(1000000));              // Lesson 6

            Console.WriteLine(RecusiveNumbers(0, 100));             // Lesson 7
        }
    }
}
