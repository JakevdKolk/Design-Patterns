using StrategyPattern.Interfaces.FlyBehavior.FlyImplementation;
using StrategyPattern.Interfaces.QuackBehavior.QuackImplementation;
using StrategyPattern.Interfaces.SwimBehavior.SwimImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            setFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new Qauck());
            SetSwimBehavior(new Swimming());


        }
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck");
        }
    }
}
