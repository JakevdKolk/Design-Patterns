using DecoratorPattern.Beverages;

namespace DecoratorPattern.Factory
{
    internal abstract class Factoryy
    {
        internal abstract Beverage CreateBeverage(EBeverages beverage);
    }
}
