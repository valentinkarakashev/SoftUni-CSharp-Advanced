namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();

            Queue<string> players = new Queue<string>(kids);

            int counting = int.Parse(Console.ReadLine());

            int round = 1;

            while (players.Count > 1) 
            {
                if (round == counting)
                {
                    Console.WriteLine($"Removed {players.Peek()}");
                    players.Dequeue();
                    round = 1;
                }
                else
                {
                    players.Enqueue(players.Peek());
                    players.Dequeue();
                    round++;
                }
            }

            Console.WriteLine($"Last is {players.Peek()}");
        }
    }
}