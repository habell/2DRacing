using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw1
{
    class hw1
    {
        public static void Anketa()
        {
            Console.WriteLine("HW1_1");
            Console.WriteLine("Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку");
            Console.WriteLine("=====================");

            string name, lastname, age, size, weight;
            
            Console.Write("Insert your name:");
            name = Console.ReadLine();

            Console.Write("Insert your lastname:");
            lastname = Console.ReadLine();

            Console.Write("Insert your age:");
            age = Console.ReadLine();

            Console.Write("Insert your size:");
            size = Console.ReadLine();            
            
            Console.Write("Insert your weight:");
            weight = Console.ReadLine();

            Console.WriteLine("Name: " + name + " LastName: " + lastname + " Age: " + age + " Size: " + size + " Weight: " + weight);
            Console.WriteLine("Name: {0} LastName: {1} Age: {2} Size: {3} Weight: {4}", name, lastname, age, size, weight);
            Console.WriteLine($"Name: {name} LastName: {lastname} Age: {age} Size: {size} Weight: {weight}");
            Console.WriteLine("=====================");
        }
    }
}
