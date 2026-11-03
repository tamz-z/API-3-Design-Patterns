using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    // Decorator: een extra IS-A Beverage, dus je kunt hem weer inpakken
    // Inheritance alleen om hetzelfde type te zijn, niet om gedrag te erven
    internal abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();

    }
}
