
namespace DataTypes
{
    internal class DataTypes
    {
        static void Main(string[] args)
        {
            ex1();

            int valueVal = 5;
            ex2(valueVal);
            Console.WriteLine("The value of the variable is {0}", valueVal);
            Console.ReadLine();

            ReferenceType refer = new ReferenceType();
            refer.valueVal = 5;
            ex3(refer);
            Console.WriteLine("The value of variable is {0}", refer.valueVal);
            Console.ReadLine();

            Console.WriteLine("4");
            ex4();

            Console.WriteLine("5");
            ex5();

            Console.WriteLine("6");
            ex6();

            Console.WriteLine("7");
            ex7();
        }

        static void ex1()
        {
            int intVal;
            double dblVal;
            string strVal;
            intVal = 10;
            dblVal = 3.142;
            strVal = "Fpt Aptech";
            Console.WriteLine("{0} is an integer value", intVal);
            Console.WriteLine("{0} is an double value", dblVal);
            Console.WriteLine("{0} is an string", strVal);
            Console.ReadLine();
        }

        static void ex2(int valueVal)
        {
            int temp = 5;
            valueVal = temp * 2;
        }

        class ReferenceType
        {
            public int valueVal;
        }

        static void ex3(ReferenceType refer)
        {
            int temp = 5;
            refer.valueVal = temp * 2;
        }

        static void ex4()
        {
            Console.WriteLine("Currency formatting - {0:C}	{1:C4}", 88.8, 888.8);
            Console.WriteLine("Integer formatting - {0:D5}", 88);
            Console.WriteLine("Exponential formatting - {0:E}", 888.8);
            Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
            Console.WriteLine("General formatting - {0:G}", 888.8888);
            Console.WriteLine("Number formatting - {0:N}", 8888888.8);
            Console.WriteLine("Hexadecimal formatting - {0:X4}", 88);
        }

        static void ex5()
        {
            DateTime dt = DateTime.Now; // obtain current time 

            Console.WriteLine("d format: {0:d}", dt);
            Console.WriteLine("D format: {0:D}", dt);

            Console.WriteLine("t format: {0:t}", dt);
            Console.WriteLine("T format: {0:T}", dt);

            Console.WriteLine("f format: {0:f}", dt);
            Console.WriteLine("F format: {0:F}", dt);

            Console.WriteLine("g format: {0:g}", dt);
            Console.WriteLine("G format: {0:G}", dt);

            Console.WriteLine("m format: {0:m}", dt);
            Console.WriteLine("M format: {0:M}", dt);

            Console.WriteLine("r format: {0:r}", dt);
            Console.WriteLine("R format: {0:R}", dt);

            Console.WriteLine("s format: {0:s}", dt);

            Console.WriteLine("u format: {0:u}", dt);
            Console.WriteLine("U format: {0:U}", dt);

            Console.WriteLine("y format: {0:y}", dt);
            Console.WriteLine("Y format: {0:Y}", dt);
        }

        static void ex6()
        {
            var i = 5;
            var s = "hello";
            var d = 1.0;
            //i is an integer
            Console.WriteLine("i*i: " + i * i);
            //s is a string
            Console.WriteLine("s in upper case:" + s.ToUpper());
            //d is a double
            Console.WriteLine("type of d:" + d.GetType());
            Console.ReadLine();
        }

        static void ex7()
        {
            var p1 = new { Name = "A", Price = 3 };
            Console.WriteLine("Name = {0}\nPrice = {1}",
                              p1.Name.ToLower(), p1.Price);
            Console.ReadLine();
        }
    }
}