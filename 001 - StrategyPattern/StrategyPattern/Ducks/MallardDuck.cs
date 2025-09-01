using StrategyPattern.Interfaces.FlyBehavior.FlyImplementation;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.QuackBehavior.QuackImplementation;
using StrategyPattern.Interfaces.SwimBehavior.SwimImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        { 
            setFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new Qauck());
            SetSwimBehavior(new Swimming());
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
