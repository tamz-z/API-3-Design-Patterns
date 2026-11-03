using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Alle eenden als type Duck: de code werkt voor elke soort eend
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();

            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.PerformSwim();
            Console.WriteLine();

            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();
            redheadDuck.PerformSwim();
            Console.WriteLine();

            decoyDuck.Display();
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();
            decoyDuck.PerformSwim();
            Console.WriteLine();

            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();
            rubberDuck.PerformSwim();
            Console.WriteLine();

            robotDuck.Display();
            robotDuck.PerformQuack();
            robotDuck.PerformFly();
            robotDuck.PerformSwim();
            Console.WriteLine();

            // Strategy Pattern: het gedrag kan tijdens het draaien worden gewisseld.
            // De batterij van de RobotDuck is leeg, dus hij kan niet meer vliegen of kwaken.
            Console.WriteLine("De batterij van de Robot Duck is leeg...");
            robotDuck.SetFlyBehavior(new FlyNoWay());
            robotDuck.SetQuackBehavior(new MuteQuack());
            robotDuck.PerformQuack();
            robotDuck.PerformFly();
        }
    }
}
