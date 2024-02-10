namespace Threeuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] nameTokens = Console.ReadLine().Split();
            string[] beerTokens = Console.ReadLine().Split();
            string[] bankTokens = Console.ReadLine().Split();
            string townName = nameTokens.Length == 5 ? $"{nameTokens[3]} {nameTokens[4]}" : nameTokens[3];

            Threeuple<string, string, string> names = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2], townName);
            Threeuple<string, int, bool> beers = new(beerTokens[0], int.Parse(beerTokens[1]), beerTokens[2] == "drunk");
            Threeuple<string, double, string> account = new(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

            Console.WriteLine(names);
            Console.WriteLine(beers);
            Console.WriteLine(account);
        }
    }
}
