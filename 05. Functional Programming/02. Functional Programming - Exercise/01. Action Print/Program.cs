namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string> print = x => Console.WriteLine(x);

            Array.ForEach(names, print);
        }
    }
}