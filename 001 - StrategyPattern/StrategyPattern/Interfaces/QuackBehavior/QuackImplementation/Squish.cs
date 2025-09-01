using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior.QuackImplementation
{
    internal class Squish : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squish");
        }
    }
}
