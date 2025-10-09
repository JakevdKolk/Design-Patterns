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

            foreach (EBeverages beverage in Enum.GetValues(typeof(EBeverages)))
            {
                cafeFactory.BeverageStore(beverage);
            }
        }
    }
}
