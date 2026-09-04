using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.FlyBehavior
{
    internal class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can fly with wings");
        }
    }
}
