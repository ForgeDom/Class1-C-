namespace ConsoleApp1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the % for this number you want to get:");
            double percentage = Convert.ToDouble(Console.ReadLine());
            double result = number * percentage / 100;
            Console.WriteLine(result);
            }
    }
}