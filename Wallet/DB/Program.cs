using System;

namespace DB
{
    class Program
    {
        static double MealCost(double pMealPrice, int pTipPercentage, int pTax)
        {
            double lTipValue = (pMealPrice * pTipPercentage) / 100;
            double lTax = (pMealPrice * pTax) / 100;
            return (int)Math.Round(pMealPrice + lTipValue + lTax);
        }

        static void Main(string[] args)
        {
            double lMealPrice; double.TryParse(Console.ReadLine(), out lMealPrice);
            double lTipTax; double.TryParse(Console.ReadLine(), out lTipTax);
            double lTax; double.TryParse(Console.ReadLine(), out lTax);

            Console.WriteLine($"The total meal cost is {MealCost(lMealPrice, (int)lTipTax, (int)lTax)} dollars.");
            Console.ReadLine();
        }
    }
}
