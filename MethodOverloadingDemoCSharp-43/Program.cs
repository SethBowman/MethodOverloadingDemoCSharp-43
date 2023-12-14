namespace MethodOverloadingDemoCSharp_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var added = Add(2.5m, 2.5m);
            Console.WriteLine(added);

            var addedTwo = Add(2, 2);
            Console.WriteLine(addedTwo);

            Greet("Seth");
            Greet("Mack", "McCall");
            Greet("Seth", "Bowman", 29);
            Greet();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static void Greet(string firstName)
        {
            Console.WriteLine($"Hello, {firstName}!");
        }

        public static void Greet(string firstName, string lastName)
        {
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }

        public static void Greet(string firstName, string lastName, int age)
        {
            if(age >= 18)
            {
                Console.WriteLine($"Hello, {firstName} {lastName}! You are {age} so you can vote!");
            }
            else
            {
                Console.WriteLine($"Hello, {firstName} {lastName}! You are {age} so you can't vote.. sorry.");
            }
        }

        public static void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
