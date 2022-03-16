//1.	Сколько всего студентов?
//2.	Сколько всего бакалавров?
//3.	Сколько всего магистров?
//4.	Вывести всех студентов(по фио) в алфавитном порядке.

using System;
using System.Collections.Generic;
using System.IO;

namespace hw3
{
    class Student
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Univercity { get; private set; }
        public string Faculty { get; private set; }
        public int Course { get; private set; }
        public string Department { get; private set; }
        public int Group { get; }
        public string City { get; private set; }
        public int Age { get; private set; }

        //Создаем конструктор
        public Student(string firstName, string lastName, string univercity, string faculty, string department, int age, int course, int group, string city)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Univercity = univercity;
            this.Faculty = faculty;
            this.Department = department;
            this.Course = course;
            this.Age = age;
            this.Group = group;
            this.City = city;
        }


        public override string ToString()
        {
            return String.Format("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}{7,5}{8,10}", FirstName, LastName, Univercity, Faculty, Department, Age, Course, Group, City);
        }
    }

    delegate bool Is(Student s);


    class Program
    {
        static void findUongStudents(List<Student> list) // HOMEWORK 3.б
        {
            int[] count = new int[7];
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Age >= 18 & list[i].Age <= 20)
                {
                    count[list[i].Course]++;
                }
            }
            Console.WriteLine("Подсчет учащихся в возрасте от 18 до 20 лет");
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine($"Студентов на {i} курсе: {count[i]}");
            }
        }

        static int SortByAge(Student st1, Student st2)
        {
            if (st1.Age > st2.Age) return 1;
            if (st1.Age < st2.Age) return -1;
            return 0;
        }
        static int SortByAgeAndCourse(Student st1, Student st2)
        {
            if (st1.Age > st2.Age) return 1;
            if (st1.Age < st2.Age) return -1;
            if (st1.Course > st2.Course) return 1;
            if (st1.Course < st2.Course) return -1;
            return 0;
        }

        static int Comparer(Student st1, Student st2)//Создаем метод для сравнения для экземпляров
        {
            //Сравниваем две строки
            //return String.Compare(st1.FirstName, st2.FirstName);
            //if (st1.Course > st2.Course) return 1;
            //if (st1.Course < st2.Course) return -1;
            //return 0;
            return st1.Course - st2.Course;
        }

        //Предикат
        static bool IsAgeBigger18(Student student)
        {
            return student.Age > 18;
        }


        static bool IsMagistr(Student student)
        {
            return student.Course == 6;
        }

        static int CountStudents(List<Student> students, Is IS)
        {
            int count = 0;
            foreach (Student student in students)
            {
                if (IS(student)) count++;
            }
            return count;
        }

        static void Main(string[] args)
        {

            int bakalav = 0;
            int magistr = 0;
            //Создаем список студентов
            List<Student> list = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_4.csv");
            //File.ReadAllLines("students_4.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    //Добавляем в список новый экземляр класса Student
                    Student t;
                    t = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), Convert.ToInt32(s[6]), int.Parse(s[7]), s[8]);
                    list.Add(t);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
            Console.WindowWidth = 160;
            Console.BufferWidth = 160;
            //Можно оставить просто MyMethod, но помнить, что мы создаем объект-делегат, который передается в метод Sort
            list.Sort(new Comparison<Student>(Comparer));
            //foreach (var v in list) Console.WriteLine(v.ToString());
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Бакалавров:{0}", CountStudents(list, (s) => s.Course == 4 || s.Course == 5));
            Console.WriteLine("Кол-во студентов старше 18:{0}", CountStudents(list, IsAgeBigger18));
            Console.WriteLine("Кол-во магистров:{0}", CountStudents(list, IsMagistr));


            // HOMEWORK 3.1
            Console.WriteLine("Кол-во студентов 5 и 6 курса:{0}", CountStudents(list, student => student.Course == 5 || student.Course == 6));
            // HOMEWORK 3.2
            findUongStudents(list);
            // HOMEWORK 3.3
            list.Sort(SortByAge);
            // HOMEWORK 3.4
            list.Sort(SortByAgeAndCourse);

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}