namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfCarsThatCanPass = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int passedCars = 0;

            Queue<string> carsQueue = new Queue<string>();

            while (command != "end")
            {
                if (command == "green")
                {
                    if (carsQueue.Count >= numOfCarsThatCanPass)
                    {
                        for (int i = 0; i < numOfCarsThatCanPass; i++)
                        {
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                    else if (carsQueue.Count > 0 && carsQueue.Count < numOfCarsThatCanPass)
                    {
                        int count = carsQueue.Count;
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}