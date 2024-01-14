namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] action = command.Split();
                if (action[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(action[1]));
                    stack.Push(int.Parse(action[2]));
                }
                else
                {
                    int times = int.Parse(action[1]);
                    if (stack.Count >= times)
                    {
                        for (int i = 0; i < times; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}