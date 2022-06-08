using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw5
{
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
                if (item[item.Length - 1] != n) resultableString += $" {item}";
            }
            return resultableString;
        }

        public static string homework_c(string str)
        {
            string[] allMessages = returnLoverStringArr(str);
            string resultableString = allMessages[0];
            for (int i = 0; i < allMessages.Length - 1; i++)
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
            for (int i = 0; i < str1.Length - 1; i++)
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
}
