namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trim en ToLower, zodat ook "J" of " j " als ja telt
            Console.Write("Developer mode? (j/n): ");
            bool developerMode = Console.ReadLine()?.Trim().ToLower() == "j";

            Console.Write("Online spelen? (j/n): ");
            bool online = Console.ReadLine()?.Trim().ToLower() == "j";

            GameFacade game = new GameFacade();

            game.StartGame(developerMode, online);

            Console.WriteLine("\nDruk op Enter om de game te stoppen...");
            Console.ReadLine();

            game.StopGame();

            Console.ReadLine();
        }
    }
}
