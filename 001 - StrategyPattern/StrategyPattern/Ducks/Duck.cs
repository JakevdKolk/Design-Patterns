using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected SwimBehavior _swimBehavior;

        protected FlyBehavior _flyBehavior;

        protected QuackBehavior _quackBehavior;

        public abstract void Display();

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }
        public void PerformSwim()
        {
            _swimBehavior.Swim();
        }

        public void setFlyBehavior(FlyBehavior fb)
        {
            this._flyBehavior = fb;
        }

        public void SetQuackBehavior(QuackBehavior qb)
        {
            this._quackBehavior = qb;
        }  

        public void SetSwimBehavior(SwimBehavior sb)
        {
            this._swimBehavior = sb;
        }
    }
}
