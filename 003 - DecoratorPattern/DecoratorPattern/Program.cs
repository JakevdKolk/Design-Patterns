using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.FactoryPattern;
using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory cafeFactory = new BeverageFactory();

            Random random = new Random();

            foreach (EBeverages beverage in Enum.GetValues(typeof(EBeverages)))
            {
                int number = random.Next(0, 3); 
                Console.WriteLine(number);
                cafeFactory.OrderBeverage(beverage, (Size)number);

                


            }
        }
    }
}
