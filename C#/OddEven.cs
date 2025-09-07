using System.Runtime.InteropServices;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string result = (num % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
    }
}
