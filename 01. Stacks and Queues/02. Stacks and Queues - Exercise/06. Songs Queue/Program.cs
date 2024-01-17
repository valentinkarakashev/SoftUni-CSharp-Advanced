using System.Threading.Channels;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songDetails = Console.ReadLine().Split(", ").ToArray();

            Queue<string> songs = new Queue<string>(songDetails);

            string command = Console.ReadLine();

            while (songs.Count > 0)
            {
                string[] songCommand = command.Split();

                if (songCommand[0] == "Play")
                {
                    if (songs.Any())
                    {
                        songs.Dequeue();
                    }
                }
                else if (songCommand[0] == "Add")
                {
                    string songName = string.Join(" ", songCommand.Skip(1));
                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songName);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}