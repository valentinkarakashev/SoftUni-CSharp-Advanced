namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[numbers.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = numbers[col];
                }
            }

            for (int row = 0; row < n - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] actions = command.Split();

                if (int.Parse(actions[1]) >= 0 && int.Parse(actions[1]) < n &&
                    int.Parse(actions[2]) >= 0 && int.Parse(actions[2]) < jaggedArray[int.Parse(actions[1])].Length)
                {
                    if (actions[0] == "Add")
                    {
                        jaggedArray[int.Parse(actions[1])][int.Parse(actions[2])] += int.Parse(actions[3]);
                    }
                    else if (actions[0] == "Subtract")
                    {
                        jaggedArray[int.Parse(actions[1])][int.Parse(actions[2])] -= int.Parse(actions[3]);
                    }
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}