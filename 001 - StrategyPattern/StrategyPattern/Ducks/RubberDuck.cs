using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.FlyBehavior.FlyImplementation;
using StrategyPattern.Interfaces.QuackBehavior.QuackImplementation;
using StrategyPattern.Interfaces.SwimBehavior.SwimImplementation;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            setFlyBehavior(new FlySkillIssue());
            SetQuackBehavior(new Squish());
            SetSwimBehavior(new Swimming());
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }


        
    }
}
