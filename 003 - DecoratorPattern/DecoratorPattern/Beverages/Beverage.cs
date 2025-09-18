using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size = Size.TALL;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public double GetSizeCost()
        {
            var mult = Size switch
            {
                Size.TALL => 1.0,
                Size.VENDI => 1.2,
                Size.GRANDE => 1.4,
                _ => 1.0
            };

            return cost() * mult;
        }

        public abstract double cost();
    }
}
