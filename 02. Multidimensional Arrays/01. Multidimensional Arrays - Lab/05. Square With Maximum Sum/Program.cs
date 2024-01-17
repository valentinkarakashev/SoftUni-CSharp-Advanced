namespace _05._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixData[0], matrixData[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int sum = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int row = 0; row < matrixData[0] - 1; row++)
            {
                for (int col = 0; col < matrixData[1] - 1; col++)
                {
                    int boxSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (boxSum > sum)
                    {
                        sum = boxSum;
                        a = matrix[row, col];
                        b = matrix[row, col + 1];
                        c = matrix[row + 1, col];
                        d = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{a} {b}");
            Console.WriteLine($"{c} {d}");
            Console.WriteLine(sum);
        }
    }
}