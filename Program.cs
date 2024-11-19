namespace ConsoleApp1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i+1}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            var multiplication = 1;
            for (int i = 0;i <  numbers.Length; i++)
            {
                multiplication *= numbers[i];
            }
            Console.WriteLine("Your numbers:");
            foreach( int i in numbers)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Max number = {numbers.Max()}");
            Console.WriteLine($"Min number = {numbers.Min()}");
            Console.WriteLine($"Multiplication = {multiplication}");
        }
    }
}