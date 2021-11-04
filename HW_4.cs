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
            int gold;
            int Crystals;
            int price = 3;

            Console.WriteLine("Сколько у вас золота?\n");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nЦена одного кристала " + price + " золота.\n" + "На все ваше золото вам получиться купить " + gold / price + " кристалов.\n" + "Сколько кристалов вы хотите приобрести?\n");
            Crystals = Convert.ToInt32(Console.ReadLine());
            gold -= Crystals * price;
            Console.WriteLine("\nСпасибо за покупку!\n" + "Вы приобрели " + Crystals + " кристалов и у вас осталось " + gold + " золота.\n");
            Console.WriteLine(": +" + Crystals + " кристалов;");
            Console.WriteLine(": -" + Crystals * price + " золота;");

            Console.ReadKey();
        }
    }
}
