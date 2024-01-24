using System;

namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] details = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = details[0];
            int columns = details[1];
            int[][] matrix = new int[rows][];

            int maxSum = 0;

            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < columns - 2; col++)
                {
                    int sum = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            sum += matrix[row + i][col + k];
                        }
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRow; row < 3 + maxRow; row++)
            {
                for (int col = maxCol; col < 3 + maxCol; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                
                Console.WriteLine();
            }
        }
    }
}