using System;


namespace homeworks1
{
    // ХАБЛИЕВ 
    class Lesson1HomeworkClass
    {
        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        public static void Pause()
        {
            Console.ReadLine();
        }
    }
    class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public User(){}
        // Конструктор просто для удобста тестирования
        public User(string name, string lName, int age, int h, int w)
        {
            this.Name = name;
            this.LastName = lName;
            this.Age = age;
            this.Height = h;
            this.Weight = w;
        }
    }
    class Program
    {
        static double math_sqrtFunct(double x1, double x2, double y1, double y2) // расчет расстояния
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
        static void Main(string[] args)
        {
            ///
            ///        LESSON 1
            ///        

            //User NewUser = new User("Гурджибек", "Иванов", 25, 180, 85);
            User NewUser = new User();
            Console.WriteLine("Введите имя пользователя: ");
            NewUser.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию пользователя: ");
            NewUser.LastName = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя: ");
            NewUser.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост пользователя: ");
            NewUser.Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес пользователя: ");
            NewUser.Weight = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {NewUser.Name}; LastName: {NewUser.LastName}; Age: {NewUser.Age}; Height: {NewUser.Height}; Weight: {NewUser.Weight}; \n");

            Console.WriteLine($"Нажмите Enter если хотите расчитать индекс массы тела, пользователя {NewUser.Name}");
            Console.WriteLine($"Если вы хотите ввести другой рост и вес, тогда введите Да и нажмите Enter");
            string consoleText = Console.ReadLine();
            double h, w = new();

            if(consoleText == "Да")
            {
                Console.WriteLine("Окей, вы выбрали ввод новых данных. \nВведите Рост:");
                h = double.Parse(Console.ReadLine()) / 100;
                Console.WriteLine("Введите вес:");
                w = double.Parse(Console.ReadLine());
            }
            else
            {
                h = (double)NewUser.Height / 100;
                w = NewUser.Weight;
            }
            Console.WriteLine($"Индекс массы тела составляет: {(int)(w/(h*h))} \n\n");

            ///
            ///     LESSON 2
            ///     

            Console.WriteLine($"Расстояние между точками с координатами x1, y1 и x2,y2: {math_sqrtFunct(1000, 10, 100, 50):f2} \n\n");

            ///
            ///     LESSON 3
            ///

            int x = 5;
            int y = 10;
            int z = 0;
            Console.WriteLine($"x: {x} y: {y} Нажмите Enter что-бы х и у поменялись местами.");
            Console.ReadLine();

            z = x;
            x = y;
            y = z;

            Console.WriteLine($"x: {x} y: {y} Нажмите Enter что-бы заменить х и у местами ещё раз, другим методом.");
            Console.ReadLine();

            (x, y) = (y, x);
            Console.WriteLine($"x: {x} y: {y}");

            ///
            ///     LESSON 4
            ///     

            Lesson1HomeworkClass.Print("Тимур Хаблиев, Владикавказ", 40, 10);
            Lesson1HomeworkClass.Pause();
        }
    }
}

