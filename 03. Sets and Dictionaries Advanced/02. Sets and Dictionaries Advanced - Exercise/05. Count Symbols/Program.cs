namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> sortedChars = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!sortedChars.ContainsKey(text[i]))
                {
                    sortedChars.Add(text[i], 0);
                }

                sortedChars[text[i]]++;
            }

            foreach (var c in sortedChars)
            {
                Console.WriteLine($"{c.Key}: {c.Value} time/s");
            }
        }
    }
}