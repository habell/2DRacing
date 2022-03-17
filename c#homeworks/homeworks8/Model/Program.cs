using System;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type type = typeof(Employee);//рефлексия

            //foreach(var prop in type.GetConstructors())
            //    Console.WriteLine(prop.Name);


            //Employees employees = new Employees();
            //employees.Add(new Employee("Ivanov", "Director", "Good worker", new DateTime(1985, 2, 3)));
            //employees.Add(new Employee("Ivanov", "Director", "Good worker", new DateTime(1985, 2, 3)));
            //employees.Add(new Employee("Ivanov", "Director", "Good worker", new DateTime(1985, 2, 3)));
            //employees.Save("data.xml");
            //employees.SaveJSON("data2.json");
            Employees employees = new Employees();
            employees.Load("data.xml");

        }
    }
}
