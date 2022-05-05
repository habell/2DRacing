using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw4
{
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
            catch (Exception e)
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
            catch (Exception e)
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
            for (int i = 0; i < arr.Count() - 1; i++)
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
    class hw1_2_3
    {
        public static void DemoHW4_123()
        {
            int[] arr = new int[20];
            arr = LessonArray.RandomArray(arr);
            string arrStr = LessonArray.ToString(arr);
            LessonArray.WriteFile("test.txt", arrStr);
            List<int> ReadedFile = LessonArray.ReadFile("test.txt");
            int count = LessonArray.FindElement(ReadedFile);
            Console.WriteLine(count);
            Console.WriteLine("Нажмите любую клавишу что-бы продолжить.");
            Console.ReadKey();

            hw4ArrayEditor arrayEditor = new hw4ArrayEditor(10, 100, 10);
            Console.WriteLine($"Sum: {arrayEditor.Sum()}");
            hw4ArrayEditor.Inverse(arrayEditor.arr);
            hw4ArrayEditor.Multi(arrayEditor.arr, 100);
            Console.WriteLine("Нажмите любую клавишу что-бы продолжить.");
            Console.ReadKey();
        }
    }
}
