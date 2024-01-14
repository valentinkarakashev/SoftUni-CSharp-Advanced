namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();   
            Stack<char> stack = new Stack<char>();

            foreach (var item in sentence)
            {
                stack.Push(item);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}