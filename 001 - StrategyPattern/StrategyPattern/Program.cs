using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.FlyBehavior.FlyImplementation;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();


            foreach(var duck in new List<Duck> { mallardDuck, redheadDuck, decoyDuck, rubberDuck, robotDuck })
            {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();
                duck.PerformSwim();
                Console.WriteLine();
            }




        }
    }
}