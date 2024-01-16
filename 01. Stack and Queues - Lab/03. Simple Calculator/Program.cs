namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] calculations = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(calculations.Reverse());

            int result = int.Parse(stack.Pop());

            while (stack.Count >= 2)
            {
                string sign = stack.Pop();
                int number = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}