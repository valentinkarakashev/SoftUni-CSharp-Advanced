namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sequence = Console.ReadLine().ToCharArray();

            if (sequence.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            Stack<char> charStack = new Stack<char>();

            foreach (var item in sequence)
            {
                if ("[{(".Contains(item))
                {
                    charStack.Push(item);
                }
                else if (item == ')' && charStack.Peek() == '(')
                {
                    charStack.Pop();
                }
                else if (item == ']' && charStack.Peek() == '[')
                {
                    charStack.Pop();
                }
                else if (item == '}' && charStack.Peek() == '{')
                {
                    charStack.Pop();
                }
            }

            Console.WriteLine(charStack.Any() ? "NO" : "YES");
        }
    }
}