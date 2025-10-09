using DecoratorPattern.Beverages;

namespace DecoratorPattern.FactoryPattern
{
    internal abstract class Factory
    {
        internal abstract Beverage CreateBeverage(EBeverages beverage);


        public Beverage BeverageStore(EBeverages order)
        {
            Beverage beverage = CreateBeverage(order);   
           
            PrintBeverage(beverage);

            return beverage;
        }


        private void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.GetSizeCost().ToString("#.##"));
        }
    }
}
