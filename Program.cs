using System.Transactions;

namespace Assignment2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculator();
        }

        static void Calculator() 
        {
            Console.WriteLine("Enter the price of your meal");
            double mealCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your gratuity percentage");
            double myGratuity = Convert.ToInt32(Console.ReadLine());
            double billTotal = myGratuity/100 * mealCost + mealCost; 
            Console.WriteLine($"The total is: ${ billTotal}");
            Console.ReadLine();
        }

    }
}
