using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task4
    {
        static void Main(string[] args)
        {
            int peopleInLine;
            const int timeForOnePerson = 10;
            int time;

            Console.WriteLine("Вы вошли в поликлинику и видите огромную очередь из старушек.\n");
            Console.Write("Сколько старушек вы видите перед собой? - ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());
            time = peopleInLine * timeForOnePerson;
            Console.WriteLine("\nВ поликлинике на одного клиента выделяется ровно " + timeForOnePerson + " минут\n");
            Console.WriteLine("До вашей очереди осталось - " + time / 60 + " часа и " + time % 60 + " минут");

            Console.ReadKey();
        }
    }
}
