using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavior.SwimImplementation
{
    internal class Swimming : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }
    }
}
