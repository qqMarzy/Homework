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
            string name, age, gender, fafavoriteDish;

            Console.Write("Ввведите свое имя: ");
            name = Console.ReadLine();
            Console.Write("Ввведите сколько вам лет: ");
            age = Console.ReadLine();
            Console.Write("Ввведите ваш пол: ");
            gender = Console.ReadLine();
            Console.Write("Ввведите ваше любимое блюдо: ");
            fafavoriteDish = Console.ReadLine();

            Console.Write($"Вас зовут {name}, вам {age} лет, ваш пол {gender} и ваше любимое блюдо {fafavoriteDish}.");

            Console.ReadKey();
        }
    }
}
