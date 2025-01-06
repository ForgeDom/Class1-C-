using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть напрямок конвертації температури:");
        Console.WriteLine("1. З Фаренгейта в Цельсій");
        Console.WriteLine("2. З Цельсія в Фаренгейт");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Введіть температуру у Фаренгейтах:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Температура в Цельсіях: {celsius:F2}");
            }
            else
            {
                Console.WriteLine("Некоректне значення температури. Спробуйте ще раз.");
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("Введіть температуру у Цельсіях:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Температура у Фаренгейтах: {fahrenheit:F2}");
            }
            else
            {
                Console.WriteLine("Некоректне значення температури. Спробуйте ще раз.");
            }
        }
        else
        {
            Console.WriteLine("Некоректний вибір. Виберіть 1 або 2.");
        }
    }
}
