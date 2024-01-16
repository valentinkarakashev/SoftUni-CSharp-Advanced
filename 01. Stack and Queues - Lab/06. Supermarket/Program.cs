namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Queue<string> customers = new Queue<string>();

            while (command != "End")
            {
                if (command == "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, customers));
                    customers.Clear();
                }
                else
                {
                    customers.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}