using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw4
{
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
                string arrStr0 = "TestLog TestPass ";
                LessonArray.WriteFile(FILE_NAME, arrStr0);
                Console.WriteLine("Скорее всего у вас просто нет нужного файла, пожалуйста, перезагрузите решение.");
                loginPass = new string[2]; // заглушка
                return;
            }
            loginPass = file.Split(' ');
        }

        public bool CheckAccount(string log, string _pass)
        {
            if (log == loginPass[0] && loginPass[1] == _pass)
            {
                return true;
            }
            return false;
        }
    }
    class hw4
    {
        public static void DemoLogin()
        {
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
