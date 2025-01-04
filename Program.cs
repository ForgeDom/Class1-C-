namespace ConsoleApp1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sum = "";
            Console.WriteLine("Enter 4 numbers:");
            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                sum += input;
            }
            Console.WriteLine($"Result - {sum}");
        }
    }
}