namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            Console.WriteLine(boiler1 == boiler2);
        }
    }
}
