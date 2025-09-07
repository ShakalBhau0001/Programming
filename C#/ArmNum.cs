using System.Runtime.InteropServices;

namespace ArmNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, r ,t = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r * r * r;
                n = n / 10;
            }
            if (sum == t)
                Console.WriteLine(t + " is an Armstrong number.");
            else
                Console.WriteLine(t + " is not an Armstrong number.");
        }
    }
}
