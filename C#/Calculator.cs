using System.Runtime.InteropServices;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, /, %): ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result;
            switch(op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;

                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Division by zero is not allowed.");
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    break;

                case '%':
                    if (num2 == 0)
                        Console.WriteLine("Error: Modulus by zero is not allowed.");
                    else
                    {
                        result = num1 % num2;
                        Console.WriteLine($"Result: {num1} % {num2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
