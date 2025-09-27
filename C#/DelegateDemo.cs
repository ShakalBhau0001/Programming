namespace DelegateDemo
{
    public delegate void Calculator1(int x, int y);
    public delegate void Calculator2(int x, int y);
    internal class Program
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition:-> " + (x + y));
        }

        public static void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction:-> " + (x - y));
        }

        public static void Mul(int x, int y)
        {
            Console.WriteLine("Multiplication:-> " + (x * y));
        }

        public static void Div(int x, int y)
        {
            Console.WriteLine("Division:-> " + (x / y));
        }
        static void Main(string[] args)
        {
            Calculator1 cal1 = new Calculator1(Add);
            Calculator2 cal2 = new Calculator2(Sub);
            cal1.Invoke(200, 200);
            Add(200, 600);
            cal2.Invoke(2000, 600);
            Sub(400, 250);
        }
    }
}
