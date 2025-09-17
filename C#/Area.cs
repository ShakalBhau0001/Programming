using System.Runtime.InteropServices;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the shape to find area:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");
            Console.Write("Enter your choice (1-3): ");
            int ch = int.Parse(Console.ReadLine());
            double a;
            switch (ch)
            {
                case 1:
                    Console.Write("Enter the radius of the circle: ");
                    double r = double.Parse(Console.ReadLine());
                    a = Math.PI * r * r;
                    Console.WriteLine("Area of Circle = "+ a);
                    break;

                case 2:
                    Console.Write("Enter the side length of the square: ");
                    double s = double.Parse(Console.ReadLine());
                    a = s * s;
                    Console.WriteLine("Area of Square = "+ a);
                    break;

                case 3:
                    Console.Write("Enter the length of the rectangle: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Enter the breadth of the rectangle: ");
                    double b = double.Parse(Console.ReadLine());
                    a = l * b;
                    Console.WriteLine("Area of Rectangle = "+ a);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
