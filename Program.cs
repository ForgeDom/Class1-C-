using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть шестизначне число:");

        string? input = Console.ReadLine();

        if (input.Length == 6 && IsAllDigits(input))
        {
            Console.WriteLine("Введіть два номери розрядів для заміни (від 1 до 6):");

            string? pos1Input = Console.ReadLine();
            string? pos2Input = Console.ReadLine();

            if (IsAllDigits(pos1Input) && IsAllDigits(pos2Input))
            {
                int pos1 = int.Parse(pos1Input);
                int pos2 = int.Parse(pos2Input);

                if (pos1 >= 1 && pos1 <= 6 && pos2 >= 1 && pos2 <= 6)
                {
                    int index1 = pos1 - 1;
                    int index2 = pos2 - 1;

                    char[] digits = input.ToCharArray();

                    char temp = digits[index1];
                    digits[index1] = digits[index2];
                    digits[index2] = temp;
      
                    string result = new string(digits);

                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Некоректно введені номери розрядів. Вони повинні бути в межах від 1 до 6.");
                }
            }
            else
            {
                Console.WriteLine("Некоректно введені номери розрядів. Введіть тільки цифри.");
            }
        }
        else
        {
            Console.WriteLine("Ви ввели не шестизначне число. Спробуйте ще раз.");
        }
    }
    static bool IsAllDigits(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}
