using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 to 100:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("That`s the wrong number!!!");
            }
        }
    }
}
