namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NxM = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[NxM[0], NxM[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] details = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = details[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] swapCommand = command.Split();

                if (swapCommand[0] == "swap" && swapCommand.Length == 5)
                {
                    if (int.Parse(swapCommand[1]) >= 0 && int.Parse(swapCommand[1]) <= matrix.GetLength(0) - 1 &&
                        int.Parse(swapCommand[2]) >= 0 && int.Parse(swapCommand[2]) <= matrix.GetLength(1) - 1 &&
                        int.Parse(swapCommand[3]) >= 0 && int.Parse(swapCommand[3]) <= matrix.GetLength(0) - 1 &&
                        int.Parse(swapCommand[4]) >= 0 && int.Parse(swapCommand[4]) <= matrix.GetLength(1) - 1)
                    {
                        string temp = matrix[int.Parse(swapCommand[1]), int.Parse(swapCommand[2])]; ;
                        matrix[int.Parse(swapCommand[1]), int.Parse(swapCommand[2])] = matrix[int.Parse(swapCommand[3]), int.Parse(swapCommand[4])];
                        matrix[int.Parse(swapCommand[3]), int.Parse(swapCommand[4])] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}