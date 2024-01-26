namespace _05._City_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                string continent = command[0];
                string country = command[1];
                string city = command[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                continents[continent][country].Add(city);
            }

            foreach (var (continent, countries) in continents)
            {
                Console.WriteLine($"{continent}:");

                foreach (var (country, cities) in countries)
                {
                    Console.Write($"  {country} -> ");
                    Console.WriteLine(string.Join(", ", cities));
                }
            }
        }
    }
}
