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
    // IS-A (inheritance): MallardDuck is een Duck
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            // Hier kiest de eend welke strategieën hij gebruikt
            quackBehavior = new RegularQuack();
            flyBehavior = new FlyWithWings();
            swimBehavior = new Swimming();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
