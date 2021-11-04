using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task8
    {
        static void Main(string[] args)
        {
            const string textForExit = "exit";
            string userText;

            Console.WriteLine("Введите любой текст для запустка цыкла \n");
            userText = Console.ReadLine();
            Console.WriteLine("\nЦыкл успешно запущен ");

            while (userText != textForExit)
            {
                Console.WriteLine("\nДля завершения цыкла введите \"" + textForExit + "\". \n");
                userText = Console.ReadLine();
            }

            Console.WriteLine("\nЦыкл успешно завершен.");

            Console.ReadKey();
        }
    }
}
