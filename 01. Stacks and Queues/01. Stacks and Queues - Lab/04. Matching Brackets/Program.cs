namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    stack.Push(i);
                }
                else if (text[i] == ')')
                {
                    int start = stack.Pop();
                    int end = i;

                    string substring = text.Substring(start, end - start + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}