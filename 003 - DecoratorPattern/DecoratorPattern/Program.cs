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
                int number = random.Next(1, 4); 
                Console.WriteLine(number);
                if (number == 1)
                {
                    cafeFactory.OrderBeverage(beverage, Size.VENDI);
                }
                else if (number == 2)
                {
                    cafeFactory.OrderBeverage(beverage, Size.GRANDE);

                }
                else
                {
                    cafeFactory.OrderBeverage(beverage, Size.TALL);

                }

            }
        }
    }
}
