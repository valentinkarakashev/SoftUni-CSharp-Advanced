namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers = numbers.OrderByDescending(x => x).Take(3).ToList();

            foreach (int number in numbers) 
            {
                Console.Write($"{number} ");
            }
        }
    }
}