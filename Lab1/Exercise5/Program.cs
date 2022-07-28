namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            long fact = 1;
            if (n < 0)
            {
                Console.WriteLine("Error!");
            } else
            {
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine("Factorial of " + n + " = " + fact);
            }
        }
    }
}