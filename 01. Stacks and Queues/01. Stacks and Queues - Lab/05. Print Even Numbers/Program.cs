namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(integers);

            for (int i = 0; i < integers.Length; i++)
            {
                if (queue.Peek() % 2 != 0)
                {
                    queue.Dequeue();
                }
                else
                {
                    queue.Dequeue();
                    queue.Enqueue(integers[i]);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}