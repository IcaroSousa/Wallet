using System;

namespace DB
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double d;
            string s = "HakerHank";

            double ii; double.TryParse(Console.ReadLine(), out ii);
            double dd; double.TryParse(Console.ReadLine(), out dd);

            var lInput = Console.ReadLine();


            Console.WriteLine((int)ii + (int)dd);
            Console.WriteLine($"{(dd + dd).ToString("#.0")}");
            Console.WriteLine($"{s}{lInput}");

            Console.ReadKey();
        }
    }
}
