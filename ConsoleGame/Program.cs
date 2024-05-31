using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int rounds = int.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            Console.WriteLine("Hero types: Soldier, Knight, Rogue");
            Console.Write("Select first hero ( hero type - hero name ): ");
            string[] firstHero = Console.ReadLine().Split(" - ");

            Console.Write("Select second hero ( hero type - hero name ): ");
            string[] secondHero = Console.ReadLine().Split(" - ");

            for (int i = 0; i < rounds; i++)
            {
                Hero one = SelectHero(firstHero);
                Hero two = SelectHero(secondHero);

                Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
            }

            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");

            Console.ReadLine();
        }

        private static Hero SelectHero(string[] hero)
        {
            string heroType = hero[0].ToLower();
            string heroName = hero[1];

            switch (heroType)
            {
                case "soldier":
                    return new Soldier(heroName);
                case "knight":
                    return new Knight(heroName);
                case "rogue":
                    return new Rogue(heroName);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
