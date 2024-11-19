namespace ConsoleApp1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lower bound:");
            var lowerBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper bound:");
            var upperBound = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1;

            Console.WriteLine("Fibonacci numbers in range:");

            if (lowerBound <= a && a <= upperBound)
                Console.Write(a + " ");

            if (lowerBound <= b && b <= upperBound)
                Console.Write(b + " ");

            while (true)
            {
                int next = a + b;
                if (next > upperBound)
                    break;

                if (next >= lowerBound)
                    Console.Write(next + " ");

                a = b;
                b = next;
            }
            Console.WriteLine();
        }
    }
}