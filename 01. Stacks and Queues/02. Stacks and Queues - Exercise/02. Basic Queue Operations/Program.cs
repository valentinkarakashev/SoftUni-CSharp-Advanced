namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] details = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < elements.Length; i++)
            {
                queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < details[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count < 1)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(details[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}