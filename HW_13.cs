using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task13
    {
        static void Main(string[] args)
        {
            const string password = "Anime";
            const int countOfAttempts = 3;
            string userText = "";

            Console.WriteLine("Введите пароль:");

            for (int i = 0; i < countOfAttempts && userText != password; i++)
            {
                userText = Console.ReadLine();

                if (userText == password)
                {
                    Console.WriteLine("Secret");

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Попробуйте еще раз.");
                }
            }

        }
    }
}
