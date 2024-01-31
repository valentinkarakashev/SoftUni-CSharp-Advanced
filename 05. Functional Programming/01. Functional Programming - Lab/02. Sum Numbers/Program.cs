namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Func<string, int> parser = x => int.Parse(x);

            int[] result = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser).ToArray();

            Console.WriteLine(result.Length);
            Console.WriteLine(result.Sum());
        }
    }
}