namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] details = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();    

            for (int i = 0; i < elements.Length; i++) 
            {
                stack.Push(elements[i]);
            }

            for (int i = 0; i < details[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Count < 1)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(details[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}