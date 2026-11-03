using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.FlyBehavior
{
    // Concrete strategy: één manier van vliegen in een eigen class (encapsulation)
    internal class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly with wings");
        }
    }
}
