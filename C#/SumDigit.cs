using System.Runtime.InteropServices;

namespace SumDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0,r;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits is: " + sum);
        }
    }
}
