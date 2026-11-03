using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    // Strategy: Duck is de context. Het gedrag zit niet in Duck, maar in losse strategy-classes.
    // Abstract: je maakt nooit een gewone Duck, alleen subclasses (IS-A)
    internal abstract class Duck
    {
        // HAS-A / composition: Duck HEEFT gedrag in plaats van het te erven
        // Program to an interface: het type is de interface, niet bijv. FlyWithWings
        // Nullable (?): de subclass zet het gedrag pas in zijn eigen constructor
        protected QuackBehavior? quackBehavior;
        protected FlyBehavior? flyBehavior;
        protected SwimBehavior? swimBehavior;

        public abstract void Display();

        // Delegeren: Duck doet het niet zelf, maar geeft het door aan het gedrag
        public void PerformQuack() => quackBehavior?.Quack();

        public void PerformFly() => flyBehavior?.Fly();

        public void PerformSwim() => swimBehavior?.Swim();

        // Setters: het gedrag kan tijdens het draaien worden gewisseld
        public void SetFlyBehavior(FlyBehavior f) => flyBehavior = f;

        public void SetQuackBehavior(QuackBehavior q) => quackBehavior = q;

        public void SetSwimBehavior(SwimBehavior s) => swimBehavior = s;
    }
}
