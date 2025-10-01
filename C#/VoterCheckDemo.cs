namespace VoterCheckDemo
{
    internal class AgeException : Exception
    {
        public AgeException(string msg) : base(msg) { }
    }
        internal class Program
        {
            public static void CheckVoter(int age)
            {
                if (age <= 18) {
                    throw new AgeException("Age Must Be Greater Than 18");
                }
                else
                {
                    Console.WriteLine($"You Are Eligible For Voting :- {age}");
                }
            }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Age:- ");
                int age = Convert.ToInt32(Console.ReadLine());
                CheckVoter(age);
                //Console.WriteLine($"Age :-{age}");
            }
            catch (AgeException e)
            {
                Console.WriteLine($"Custom Exception Caught :- {e.Message}");
            }
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
