namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            HashSet<string> parkingLot = new HashSet<string>();

            while (command != "END")
            {
                string[] input = command.Split(", ");

                if (input[0] == "IN")
                {
                    parkingLot.Add(input[1]);
                }
                else if (input[0] == "OUT")
                {
                    parkingLot.Remove(input[1]);
                }

                command = Console.ReadLine();
            }

            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, parkingLot));
            }
        }
    }
}