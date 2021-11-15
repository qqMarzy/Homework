using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task11
    {
        static void Main(string[] args)
        {
            int factor = 2;
            int multiplicand = 7;
            int maxValue = 98;

            for (int i = multiplicand; i < maxValue; i *= factor)
            {
                Console.WriteLine(i);
            }
        }
    }
}
