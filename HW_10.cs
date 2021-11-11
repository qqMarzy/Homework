using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task10
    {
        static void Main(string[] args)
        {
            const string textForExit = "Exit";
            string userText = "";
            string password = "";
            Random random = new Random();
            int randomNumber;
            int randomNumberMax;
            int randomNumberMin;

            Console.WriteLine("Добро пожаловать.\nДля выхода введите \"" + textForExit + "\"\n");
            while (userText != textForExit)
            {
                if (password.Length > 0)
                {
                    Console.WriteLine("Введите пароль: ");
                    userText = Console.ReadLine();
                    if (userText == password)
                    {
                        Console.WriteLine("\nПравильный пароль");
                    }
                    else if (userText == "ViewPassword")
                    {
                        Console.WriteLine("\nВаш пароль: " + password);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nПопробуйте еще раз\n");
                        Console.WriteLine("ViewPassword - посмотреть свой пароль.");
                        continue;
                    }
                }
                Console.WriteLine("\nВыберите операцию: ");
                Console.WriteLine("SetTextColor - изменить цвет текста консоли.");
                Console.WriteLine("SetBackgroundColor - изменить цвет фона консоли.");
                Console.WriteLine("SetPassword - установить пароль.");
                Console.WriteLine("GetRandomNumber - получить рандомное число.");
                Console.WriteLine("ViewPassword - посмотреть свой пароль.");
                Console.WriteLine("Clear - очистить консоль.");
                Console.WriteLine("\nExit - выход из консоли.");
                userText = Console.ReadLine();
                switch (userText)
                {
                    case "SetTextColor":
                        Console.WriteLine("\nВыберите цвет из предложенных вариантов: ");
                        Console.WriteLine("White - Белый.");
                        Console.WriteLine("Blue - Синий.");
                        Console.WriteLine("Red - Красный.");
                        Console.WriteLine("Green - Зеленый.");
                        Console.WriteLine("Black - Чёрный.");
                        userText = Console.ReadLine();
                        switch(userText)
                        {
                            case "White":
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case "Blue":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "Red":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "Green":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "Black":
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                        }
                        Console.Clear();
                        break;
                    case "SetBackgroundColor":
                        Console.WriteLine("\nВыберите цвет из предложенных вариантов: ");
                        Console.WriteLine("White - Белый.");
                        Console.WriteLine("Blue - Синий.");
                        Console.WriteLine("Red - Красный.");
                        Console.WriteLine("Green - Зеленый.");
                        Console.WriteLine("Black - Чёрный.");
                        userText = Console.ReadLine();
                        switch (userText)
                        {
                            case "White":
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            case "Blue":
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            case "Red":
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case "Green":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "Black":
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                        }
                        Console.Clear();
                        break;
                    case "SetPassword":
                        Console.WriteLine("\nПридумайте пароль: ");
                        password = userText = Console.ReadLine();
                        break;
                    case "GetRandomNumber":
                        Console.Write("Введите минимальное значение: ");
                        randomNumberMin = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите максимальное значение: ");
                        randomNumberMax = Convert.ToInt32(Console.ReadLine());
                        randomNumber = random.Next(randomNumberMin, randomNumberMax + 1);
                        Console.WriteLine("Ваше число: " + randomNumber);
                        break;
                    case "ViewPassword":
                        if (password.Length > 0)
                        {
                            Console.WriteLine("\nВаш пароль: " + password);
                        }
                        else
                        {
                            Console.WriteLine("\nУ вас нет пароля. Для установки пароля введите \"SetPassword\".");
                        }
                        break;
                    case "Clear":
                        Console.Clear();
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nНе удалось распознать комманду.");
                        break;
                }
            }
        }
    }
}
