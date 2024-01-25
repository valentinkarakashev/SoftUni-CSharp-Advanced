namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> shopDetails = new Dictionary<string, Dictionary<string, double>>();

            while (command != "Revision") 
            {
                string[] input = command.Split(", ");

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shopDetails.ContainsKey(shop))
                {
                    shopDetails.Add(shop, new Dictionary<string, double>());
                }

                shopDetails[shop].Add(product, price);

                command = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, double>> sortedShopDetails = shopDetails
                .OrderBy(x => x.Key).ToDictionary(key => key.Key, key => key.Value);

            foreach (var item in sortedShopDetails)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var value in item.Value)
                {
                    Console.WriteLine($"Product: {value.Key}, Price: {value.Value}");
                }
            }
        }
    }
}