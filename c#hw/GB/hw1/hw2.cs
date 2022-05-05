using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw1
{
    class hw2
    {
        public static void HumanBodyIndex()
        {
            Console.WriteLine("HW1_2");
            Console.WriteLine("Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.");
            Console.WriteLine("=====================");

            Console.Write("Insert your weight:");
            float weight = float.Parse(Console.ReadLine());

            Console.Write("Insert your size:");
            float size = (float.Parse(Console.ReadLine()) / 100);

            float index = weight / (size * size);
            Console.WriteLine("Index is: " + index);
            Console.WriteLine("=====================");
        }

    }
}
