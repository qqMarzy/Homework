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
            string textForExit;

            while(true)
            {
                Console.WriteLine("\nДля завершения цыкла введите \"exit\". \n");
                textForExit = Console.ReadLine();
                if (textForExit == "exit")
                {
                    break;
                }
            }

            Console.WriteLine("Цыкл успешно завершен.");

            Console.ReadKey();
        }
    }
}
