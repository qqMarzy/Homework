using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task9
    {
        static void Main(string[] args)
        {
            const string textForExit = "exit";
            string userText = "";

            float rubToUsd = 0.014f, rubToCzk = 0.31f, usdToRub = 71.44f, usdToCzk = 21.94f, czkToRub = 3.26f, czkToUsd = 0.046f;

            float rub;
            float usd;
            float czk;

            float currencyCount;


            Console.WriteLine("Добро пожаловать в обменник.\nДля выхода из обменника введите \"" + textForExit + "\"\n");

            Console.WriteLine("Для начала введите сколько у вас денег в (рублях, долларах и чешских кронах)\n");

            Console.Write("Введите баланс рублей: ");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс чешских крон: ");
            czk = Convert.ToSingle(Console.ReadLine());

            while (userText != textForExit)
            {
                Console.WriteLine("\nВыберите операцию: ");
                Console.WriteLine("1 - Обменять рубли на доллары");
                Console.WriteLine("2 - Обменять рубли на чешские кроны");
                Console.WriteLine("3 - Обменять доллары на рубли");
                Console.WriteLine("4 - Обменять доллары на чешские кроны");
                Console.WriteLine("5 - Обменять чешские кроны на рубли");
                Console.WriteLine("6 - Обменять чешские кроны на доллары");
                Console.WriteLine("\nexit - выход из обменника\n");
                userText = Console.ReadLine();

                switch (userText)
                {
                    case "1":
                        Console.WriteLine("\nОбмен рублей на доллары\n");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub > currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount * rubToUsd;

                            Console.WriteLine($"\nОперация прошла успешно!\nНа вашем счету: {rub} рублей | {usd} долларов | {czk} чешских крон.");
                        }
                        else
                        {
                            Console.WriteLine("\n!Недопустимое кол-во рублей.\n");
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nОбмен рублей на чешские кроны\n");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub > currencyCount)
                        {
                            rub -= currencyCount;
                            czk += currencyCount * rubToCzk;

                            Console.WriteLine($"\nОперация прошла успешно!\nНа вашем счету: {rub} рублей | {usd} долларов | {czk} чешских крон.");
                        }
                        else
                        {
                            Console.WriteLine("\n!Недопустимое кол-во рублей.\n");
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nОбмен долларов на рубли\n");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd > currencyCount)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;

                            Console.WriteLine($"\nОперация прошла успешно!\nНа вашем счету: {rub} рублей | {usd} долларов | {czk} чешских крон.");
                        }
                        else
                        {
                            Console.WriteLine("\n!Недопустимое кол-во долларов.\n");
                        }
                        break;
                    case "4":
                        Console.WriteLine("\nОбмен долларов на чешские кроны\n");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd > currencyCount)
                        {
                            usd -= currencyCount;
                            czk += currencyCount * usdToCzk;

                            Console.WriteLine($"\nОперация прошла успешно!\nНа вашем счету: {rub} рублей | {usd} долларов | {czk} чешских крон.");
                        }
                        else
                        {
                            Console.WriteLine("\n!Недопустимое кол-во долларов.\n");
                        }
                        break;
                    case "5":
                        Console.WriteLine("\nОбмен чешских крон на рубли\n");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (czk > currencyCount)
                        {
                            czk -= currencyCount;
                            rub += currencyCount * czkToRub;

                            Console.WriteLine($"\nОперация прошла успешно!\nНа вашем счету: {rub} рублей | {usd} долларов | {czk} чешских крон.");
                        }
                        else
                        {
                            Console.WriteLine("\n!Недопустимое кол-во чешских крон.\n");
                        }
                        break;
                    case "6":
                        Console.WriteLine("\nОбмен чешских крон на доллары\n");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (czk > currencyCount)
                        {
                            czk -= currencyCount;
                            usd += currencyCount * czkToUsd;

                            Console.WriteLine($"\nОперация прошла успешно!\nНа вашем счету: {rub} рублей | {usd} долларов | {czk} чешских крон.");
                        }
                        else
                        {
                            Console.WriteLine("\n!Недопустимое кол-во чешских крон.\n");
                        }
                        break;
                }
            }

            Console.WriteLine("\nВы вышли из обменника.");

            Console.ReadKey();
        }
    }
}
