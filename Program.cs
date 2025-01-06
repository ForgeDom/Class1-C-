using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть дату у форматі ДД.ММ.РРРР (наприклад, 22.12.2021):");

        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            string season = GetSeason(date);

            string dayOfWeek = date.ToString("dddd", CultureInfo.InvariantCulture);

            Console.WriteLine($"{season} {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Некоректний формат дати. Спробуйте ще раз.");
        }
    }

    static string GetSeason(DateTime date)
    {
        int month = date.Month;
        int day = date.Day;

        if ((month == 12 && day >= 21) || month == 1 || month == 2 || (month == 3 && day < 21))
        {
            return "Winter";
        }
        else if ((month == 3 && day >= 21) || month == 4 || month == 5 || (month == 6 && day < 21))
        {
            return "Spring";
        }
        else if ((month == 6 && day >= 21) || month == 7 || month == 8 || (month == 9 && day < 21))
        {
            return "Summer";
        }
        else
        {
            return "Autumn";
        }
    }
}