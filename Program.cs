namespace ConsoleApp1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter line length:");
            var length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sign:");
            var sign = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter 1 - Horizontal line; 2 - Vertical line");
            var choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (choice == '1')
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(sign);
                }
            }
            else if(choice == '2')
            {
                for(int i = 0;i < length; i++)
                {
                    Console.WriteLine(sign);
                }
            }
        }
    }
}