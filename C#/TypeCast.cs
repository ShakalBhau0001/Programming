namespace TypeCast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n= Convert.ToInt32(Console.ReadLine());
            double d = (double) n;
            Console.WriteLine("Casted number: " + d);
        }
    }
}
