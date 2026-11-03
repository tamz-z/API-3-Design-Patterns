using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        // Nullable (?): de subclass zet het gedrag pas in zijn eigen constructor
        protected QuackBehavior? quackBehavior;
        protected FlyBehavior? flyBehavior;
        protected SwimBehavior? swimBehavior;

        public abstract void Display();

        public void PerformQuack() => quackBehavior?.Quack();

        public void PerformFly() => flyBehavior?.Fly();

        public void PerformSwim() => swimBehavior?.Swim();

        public void SetFlyBehavior(FlyBehavior f) => flyBehavior = f;

        public void SetQuackBehavior(QuackBehavior q) => quackBehavior = q;

        public void SetSwimBehavior(SwimBehavior s) => swimBehavior = s;
    }
}
