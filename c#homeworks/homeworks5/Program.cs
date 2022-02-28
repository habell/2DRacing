using System;
using System.Text.RegularExpressions;

namespace homeworks5
{
    class Program
    {
        // Хаблиев
       static class Message
        {
            static string[] returnLoverStringArr(string str)
            {
                str = str.ToLower();
                return str.Split(" ");
            }
            public static string homework_a(string str, int n)
            {
                string[] allMessages = returnLoverStringArr(str);
                string resultableString = "";
                foreach (var item in allMessages)
                {
                    if (item.Length <= n)
                    {
                        Console.WriteLine(item);
                        resultableString += $" {item}";
                    }
                }
                return resultableString;
            }
            public static string homework_b(string str, char n)
            {
                string[] allMessages = returnLoverStringArr(str);
                string resultableString = "";
                foreach (var item in allMessages)
                {
                    if(item[item.Length - 1] != n) resultableString += $" {item}";
                }
                return resultableString;
            }

            public static string homework_c(string str)
            {
                string[] allMessages = returnLoverStringArr(str);
                string resultableString = allMessages[0];
                for (int i = 0; i < allMessages.Length-1; i++)
                {
                    if (allMessages[i].Length < allMessages[i + 1].Length)
                    {
                        resultableString = allMessages[i + 1];
                    }
                }
                return resultableString;
            }

            public static void homework_3(string str1, string str2)
            {
                string str1_ = "";
                for (int i = 0; i < str1.Length-1; i++)
                {
                    str1_ += $"{str1[i + 1]}{str1[i]}";
                    i++;
                }
                Console.WriteLine(str1_);
                Console.WriteLine(str2);
                if (str1_ == str2)
                    Console.WriteLine($"Строка {str2} является перестановкой строки {str1}");
                else
                    Console.WriteLine("Совпадения перестановки не обнаружено!");
            }
        }

        static class LogPassReg
        {
            const string login = "log";
            const string password = "pass";

            static string log, pass;
            static bool acces = false;

            public static void HW1()
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
        static void Main(string[] args)
        {
            LogPassReg.HW1(); // Homework 1
            // Homework 2
            var str = "Слово В Котором есть какие-то символы требует расчленения";
            Message.homework_a(str, 5);
            Console.WriteLine(Message.homework_b(str, 'о'));
            Console.WriteLine(Message.homework_c(str));

            // Homework 3
            Message.homework_3("abcd", "badc");

            Console.ReadKey();
        }
    }
}
