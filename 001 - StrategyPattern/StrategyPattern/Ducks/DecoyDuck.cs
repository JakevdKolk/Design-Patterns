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
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            setFlyBehavior(new FlySkillIssue());
            SetQuackBehavior(new TheFactoryMustGrow());
            SetSwimBehavior(new NoSwim());

        }
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
    }
}
