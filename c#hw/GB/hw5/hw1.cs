using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GB.hw5
{
    class hw1
    {
        const string login = "log";
        const string password = "pass";

        static string log, pass;
        static bool acces = false;

        public static void LogPassHW()
        {
            while (!acces)
            {
                Console.Write("ВВедите логин: ");
                log = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pass = Console.ReadLine();
                Regex reg = new Regex(@"^[a-zA-ZА-Яа-я]{1}[a-zA-ZА-Яа-я0-9]{1,10}");
                if (reg.IsMatch(log) & reg.IsMatch(pass))
                {
                    if (log == login & pass == password)
                    {
                        Console.WriteLine("Доступ разрешен");
                        acces = true;
                    }
                    else
                        Console.WriteLine("Неверный логин или пароль");
                }
                else
                    Console.WriteLine("Ошибка ввода символа!");
            }
        }
    }
}
