namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (commands[0] == 1)
                {
                    stack.Push(commands[1]);
                }
                else if (commands[0] == 2)
                {
                    stack.Pop();
                }
                else if (commands[0] == 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (commands[0] == 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}