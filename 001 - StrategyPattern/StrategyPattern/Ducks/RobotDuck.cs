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
    internal class RobotDuck : Duck
    {
        public RobotDuck()
        {
            setFlyBehavior(new FlyWithRocket());
            SetQuackBehavior(new TheFactoryMustGrow());
            SetSwimBehavior(new NoSwim());
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
        }
    }
}
