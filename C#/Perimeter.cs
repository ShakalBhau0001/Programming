namespace Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius : ");
            float r1 = float.Parse(Console.ReadLine());
            float coc1 = (float)(2 * Math.PI * r1);
            Console.WriteLine("Perimeter (circumference) of a circle of radius " + r1 + ":- " + coc1);
        }
    }
}
