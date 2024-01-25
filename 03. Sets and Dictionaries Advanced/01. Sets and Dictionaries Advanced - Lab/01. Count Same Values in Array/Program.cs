namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> values = Console.ReadLine().Split().Select(double.Parse).ToList();

            Dictionary<double, int> pairs = new Dictionary<double, int>();

            foreach (var key in values) 
            {
                if (!pairs.ContainsKey(key))
                {
                    pairs.Add(key, 0);
                }

                pairs[key]++;
            }

            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}