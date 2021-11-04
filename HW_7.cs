using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task7
    {
        static void Main(string[] args)
        {
            string text;
            int counter;

            Console.Write("Введите свой текст: ");
            text = Console.ReadLine();
            Console.Write("\nВведите сколько раз должеж вывестись ваш текст: ");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(text);
            }

            Console.ReadKey();
        }
    }
}
