namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string> print = x => Console.WriteLine($"Sir {x}");

            Array.ForEach(names, print);
        }
    }
}