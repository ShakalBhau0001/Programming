using System.Runtime.InteropServices;

namespace FactoNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine("Factorial of " + n + " is: " + f);
        }
    }
}
