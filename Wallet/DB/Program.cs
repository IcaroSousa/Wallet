using System;

namespace DB
{
    class Program
    {

        static void Main(string[] args)
        {
            int lNumber; int.TryParse(Console.ReadLine(), out lNumber);

            if(lNumber % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if(lNumber > 20 || (lNumber >= 2 && lNumber <= 5))
                {
                    Console.WriteLine("Not Weird");
                }
                else 
                if(lNumber >= 6 && lNumber <= 20)    
                {
                    Console.WriteLine("Weird");                   
                }
            }
        }
    }
}
