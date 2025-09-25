using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factory;
using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factoryy cafeFactory = new BeverageFactory();

            foreach (EBeverages beverage in Enum.GetValues(typeof(EBeverages)))
            {
                cafeFactory.CreateBeverage(beverage);
            }
        }
    }
}
