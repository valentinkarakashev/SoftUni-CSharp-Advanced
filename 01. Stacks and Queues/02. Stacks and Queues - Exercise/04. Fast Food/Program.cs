using System.Threading.Channels;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orderDetails = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(orderDetails);

            Console.WriteLine(orders.Max());

            while (true)
            {
                if (orders.Count < 1)
                {
                    Console.WriteLine("Orders complete");
                    return;
                }

                if (quantity >= orders.Peek())
                {
                    quantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
        }
    }
}