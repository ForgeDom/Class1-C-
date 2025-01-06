using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть два числа для визначення діапазону:");

        Console.Write("Перше число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Друге число: ");
        int num2 = int.Parse(Console.ReadLine());

        int start, end;

        if (num1 < num2)
        {
            start = num1;
            end = num2;
        }
        else
        {
            start = num2;
            end = num1;
        }

        Console.WriteLine($"Діапазон: від {start} до {end}");
        Console.WriteLine("Парні числа у цьому діапазоні:");

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();
    }
}
