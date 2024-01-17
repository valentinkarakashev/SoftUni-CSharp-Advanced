namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] details = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(details);

            int sum = 0;
            int usedRacks = 1;

            while (clothes.Count > 0)
            {
                if (sum + clothes.Peek() <= rackCapacity)
                {
                    sum += clothes.Pop();
                }
                else
                {
                    usedRacks++;
                    sum = 0;
                }
            }

            Console.WriteLine(usedRacks);
        }
    }
}