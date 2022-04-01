using System;

namespace hw1
{
    class Program
    {

        // HOMEWORK 1
        static void Main(string[] args)
        {
            foreach (var item in typeof(DateTime).GetProperties())
            {
                Console.WriteLine(item);
            }
        }
    }
}
