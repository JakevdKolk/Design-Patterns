using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavior.SwimImplementation
{
    internal class NoSwim : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I can't swim!");
        }
    }
}
