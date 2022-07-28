namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Phone: ");
            int phone = int.Parse(Console.ReadLine());


            Console.WriteLine(name + " " + address + " " + phone);
        }
    }
}