using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;

namespace DecoratorPattern.Factory
{
    internal class BeverageFactory : Factoryy
    {
        internal override Beverage CreateBeverage(EBeverages beverage)
        {
            Beverage result;

            switch (beverage)
            {
                case EBeverages.Espresso:
                    result = new Espresso();
                    break;

                case EBeverages.Lungo:
                    result = new Water(new Espresso());
                    break;
                        
                case EBeverages.Americano:
                    result = new Water(new Water(new Espresso()));
                    break;

                case EBeverages.Doppio:
                    result = new EspressoCondiment(new Espresso());
                    break;

                case EBeverages.Macchiato:
                    result = new MilkFoam(new Espresso());
                    break;

                case EBeverages.Corretta:
                    result = new Liqour(new Espresso());
                    break;

                case EBeverages.ConPanna:
                    result = new Whip(new Espresso());
                    break;

                case EBeverages.Cappuccino:
                    result = new MilkFoam(new SteamedMilk(new Espresso()));
                    break;

                case EBeverages.CaffeLatte:
                    result = new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso())));
                    break;

                case EBeverages.FlatWhite:
                    result = new SteamedMilk(new SteamedMilk(new Espresso()));
                    break;

                case EBeverages.Romana:
                    result = new Lemon(new Espresso());
                    break;

                case EBeverages.Morocchino:
                    result = new MilkFoam(new ChocolateCondiment(new Espresso()));
                    break;

                case EBeverages.Mocha:
                    result = new Whip(new SteamedMilk(new ChocolateCondiment(new Espresso())));
                    break;

                case EBeverages.Bicerin:
                    result = new Whip(new WhiteChocolate(new BlackChocolate(new Espresso())));
                    break;

                case EBeverages.Breve:
                    result = new HalfMilk(new MilkFoam(new Espresso()));
                    break;

                case EBeverages.Raf:
                    result = new Cream(new VanillaSugar(new Espresso()));
                    break;

                case EBeverages.MeadRaf:
                    result = new Cream(new Honey(new Espresso()));
                    break;

                case EBeverages.Galao:
                    result = new MilkFoam(new MilkFoam(new Espresso()));
                    break;

                case EBeverages.Affogato:
                    result = new IceCream(new EspressoCondiment(new Espresso()));
                    break;

                case EBeverages.Vienna:
                    result = new Whip(new Whip(new EspressoCondiment(new Espresso())));
                    break;

                case EBeverages.Glace:
                    result = new IceCream(new Espresso());
                    break;

                case EBeverages.ChocolateMilk:
                    var chocolateMilk = new Chocolate();
                    chocolateMilk.Size = Size.GRANDE;
                    result = new Milk(new Milk(chocolateMilk));
                    break;

                case EBeverages.DemiCreme:
                    result = new Cream(new Cream(new EspressoCondiment(new Espresso())));
                    break;

                case EBeverages.LatteMacchiato:
                    result = new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso())));
                    break;

                case EBeverages.Freddo:
                    result = new Ice(new Liqour(new Espresso()));
                    break;

                case EBeverages.Frappuccino:
                    result = new Whip(new SteamedMilk(new Ice(new Espresso())));
                    break;

                case EBeverages.CaramelFrappuccino:
                    result = new Syrup(new Cream(new SteamedMilk(new Ice(new Espresso()))));
                    break;

                case EBeverages.Frappe:
                    result = new IceCream(new SteamedMilk(new SteamedMilk(new Espresso())));
                    break;

                case EBeverages.IrishCoffee:
                    result = new Whip(new Whiskey(new EspressoCondiment(new Espresso())));
                    break;

                default:
                    throw new ArgumentException($"Unknown beverage type: {beverage}");
            }

            PrintBeverage(result);
            return result;
        }

        private void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.GetSizeCost().ToString("#.##"));
        }
    }
}
