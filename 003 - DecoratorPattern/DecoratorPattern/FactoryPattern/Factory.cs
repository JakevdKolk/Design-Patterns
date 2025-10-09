using DecoratorPattern.Beverages;

namespace DecoratorPattern.FactoryPattern
{
    internal abstract class Factory
    {
        internal abstract Beverage CreateBeverage(EBeverages beverage);

        //speciaal voor jouw gefixed robert
        public Beverage OrderBeverage(EBeverages order, Size size)
        {
            Beverage beverage = CreateBeverage(order);   
           
            beverage.Size = size;

            PrintBeverage(beverage);

            return beverage;
        }


        private void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.GetSizeCost().ToString("#.##"));
        }
    }
}
