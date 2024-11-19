namespace ConsoleApp1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number;
                Console.WriteLine("Enter number with 6 units:");
                number = Convert.ToInt32(Console.ReadLine());
                string numberStr = number.ToString();
                if (numberStr.Length == 6)
                {
                    String reverse = new string(number.ToString().Reverse().ToArray());
                    Console.WriteLine($"Reversed number -  {reverse}");
                    break;
                }
                else
                {
                    Console.WriteLine("Number doesn`t have 6 units!!!");
                }
            }

        }
    }
}