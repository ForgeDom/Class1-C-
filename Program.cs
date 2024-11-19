namespace ConsoleApp1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Number A should be less than B:");
                Console.WriteLine("Enter number A:");
                var a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number B:");
                var b = Convert.ToInt32(Console.ReadLine());
                if (a < b)
                {
                    for (int i = a; i <= b; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("A is bigger than B!!!");
                }
            }
        }
    }
}