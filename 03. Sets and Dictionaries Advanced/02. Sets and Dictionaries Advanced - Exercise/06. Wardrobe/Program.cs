namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string[] clothes = command[1].Split(",");

                if (!wardrobe.ContainsKey(command[0]))
                {
                    wardrobe.Add(command[0], new Dictionary<string, int>());

                    foreach (var cloth in clothes)
                    {
                        if (!wardrobe[command[0]].ContainsKey(cloth))
                        {
                            wardrobe[command[0]].Add(cloth , 0);
                        }

                        wardrobe[command[0]][cloth]++;
                    }
                }
                else
                {
                    foreach (var cloth in clothes)
                    {
                        if (!wardrobe[command[0]].ContainsKey(cloth))
                        {
                            wardrobe[command[0]].Add(cloth, 0);
                        }

                        wardrobe[command[0]][cloth]++;
                    }
                }
            }

            string[] searchItem = Console.ReadLine().Split();

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var cloth in item.Value)
                {
                    if (item.Key == searchItem[0] && cloth.Key == searchItem[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}