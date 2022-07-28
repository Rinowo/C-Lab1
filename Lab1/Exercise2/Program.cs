namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

           
                if (a > b && a > c)
                {
                    Console.WriteLine("Number " + a );
                } else if (b > a && b > c)
                {
                    Console.WriteLine("Number " + b);
                } else
                {
                    Console.WriteLine("Number " + c);
                }
           
        }
    }
}