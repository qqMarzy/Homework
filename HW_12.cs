using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task12
    {
        static void Main(string[] args)
        {
            string userName;
            char userChar;

            Console.Write("Введите ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("\nВведите любой символ: ");
            userChar = Convert.ToChar(Console.ReadLine());
            Console.Write("\n");

            for (int i = 0; i < userName.Length + 2; i++)
            {
                Console.Write(userChar);
            }

            Console.WriteLine("\n" + userChar + userName + userChar);

            for (int i = 0; i < userName.Length + 2; i++)
            {
                Console.Write(userChar);
            }

            Console.ReadKey();
        }
    }
}
