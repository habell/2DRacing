using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework4;

namespace homeworks4
{
    // Хаблиев
    // Homework 1, 2, 3, 4 

    struct LoginPass
    {
        const string FILE_NAME = "login.lua";
        public string[] loginPass { get; set; }
        private string file;

        public void initializeAccount()
        {
            try
            {
                file = File.ReadAllText(FILE_NAME);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Кажется вы получили какое-то исключение: \n {e}");
            }
            loginPass = file.Split(' ');
        }

        public bool CheckAccount(string log, string _pass)
        {
            if (log == loginPass[0] && loginPass[1] == _pass){
                return true;
            }
            return false;
        }
    }


    static class LessonArray
    {

        public static int[] RandomArray(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10000, 10000);
            }
            return arr;
        }

        public static string ToString(int[] arr)
        {
            string arrString = "";
            foreach (int j in arr)
                arrString += j + " ";

            return arrString;
        }

        public static void WriteFile(string filename, string data)
        {
            StreamWriter SW = null;
            try
            {
                SW = new StreamWriter(filename);
                SW.WriteLine(data);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка!");
                Console.WriteLine(e);
            }
            finally
            {
                SW?.Close();
            }
        }
        public static List<int> ReadFile(string filename)
        {
            string file = null;
            string[] fileArr;
            var arr = new List<int>();
            try
            {
                file = File.ReadAllText(filename);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                fileArr = file.Split(' ');
                int ParseResult;
                foreach (var data in fileArr)
                    if (int.TryParse(data, out ParseResult))
                        arr.Add(ParseResult);
            }
            return arr;
        }

        public static int FindElement(List<int> arr)
        {
            int count = 0;
            for (int i=0; i < arr.Count()-1; i++)
            {
                if (arr[i] % 3 == 0)
                    if (arr[i + 1] % 3 != 0)
                        count++;
                    else;
                else
                    if (arr[i + 1] % 3 == 0)
                        count++;
            }

            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            arr = LessonArray.RandomArray(arr);
            string arrStr = LessonArray.ToString(arr);
            LessonArray.WriteFile("test.txt", arrStr);
            List<int> ReadedFile = LessonArray.ReadFile("test.txt");
            int count = LessonArray.FindElement(ReadedFile);
            Console.WriteLine(count);
            Console.ReadKey();

            homework3 hw3 = new homework4.homework3(10, 100, 10);
            Console.WriteLine($"Sum: {hw3.Sum()}");
            homework3.Inverse(hw3.arr);
            homework3.Multi(hw3.arr, 100);
            Console.ReadKey();

            LoginPass User = new LoginPass();
            User.initializeAccount();

            if (User.CheckAccount("TestLog", "TestPass")) 
                Console.WriteLine("Успешно");
            else 
                Console.WriteLine("Неуспешно");

            Console.ReadKey();
        }
    }
}
