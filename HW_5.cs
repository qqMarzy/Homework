using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task5
    {
        static void Main(string[] args)
        {
            const int timeForOnePerson = 10;
            int peopleInLine;
            int waitingTime;
            int hours;
            int minutes;

            Console.WriteLine("Вы вошли в поликлинику и видите огромную очередь из старушек.\n");
            Console.Write("Сколько старушек вы видите перед собой? - ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());
            time = peopleInLine * timeForOnePerson;
            Console.WriteLine("\nВ поликлинике на одного клиента выделяется ровно " + timeForOnePerson + " минут\n");
            hours = waitingTime / 60;
            minutes = waitingTime % 60;
            Console.WriteLine("До вашей очереди осталось - " + hour + " часа и " + minutes + " минут");

            Console.ReadKey();
        }
    }
}
