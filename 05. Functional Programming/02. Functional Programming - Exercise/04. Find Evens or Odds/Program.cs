namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string criteria = Console.ReadLine();
            int startNumber = bounds[0];
            int endNumber = bounds[1];

            List<int> numbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate = i => true;

            if (criteria == "even")
            {
                predicate = i => i % 2 == 0;
            }
            else if (criteria == "odd")
            {
                predicate = i => i % 2 != 0;
            }

            var filteredNumbers = numbers.Where(new Func<int, bool>(predicate));

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}