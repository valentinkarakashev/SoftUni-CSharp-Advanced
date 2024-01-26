namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> sortedElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();

                foreach (string element in elements)
                {
                    sortedElements.Add(element);
                }
            }

            foreach (var element in sortedElements)
            {
                Console.Write($"{element} ");
            }
        }
    }
}