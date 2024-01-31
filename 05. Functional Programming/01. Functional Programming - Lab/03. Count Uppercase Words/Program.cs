namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> checker = x => char.IsUpper(x[0]);

            text = text.Where(x => checker(x)).ToArray();

            foreach (var item in text) 
            {
                Console.WriteLine(item);
            }
        }
    }
}