using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.hw2
{
    class hw4
    {
        public static void SignIn(string login, string pass)
        {
            int maxCount = 3;

            for (int i = maxCount; i > 0; i--)
            {
                Console.WriteLine("SignIn");
                Console.WriteLine("Your Login: ");
                string Login = Console.ReadLine();
                Console.WriteLine("Your Password: ");
                string Pass = Console.ReadLine();

                if (login == Login)
                {
                    if (Pass == pass) 
                    {
                        Console.WriteLine("You are successfully logged in.");
                        return;
                    }
                    else
                        Console.WriteLine("Wrong password! Tries left to try: " + (i - 1));
                }
                else
                    Console.WriteLine("Wrong login! Tries left to try: " + (i - 1));
            }
            Console.WriteLine("SignIn Error");
        }
    }
}
