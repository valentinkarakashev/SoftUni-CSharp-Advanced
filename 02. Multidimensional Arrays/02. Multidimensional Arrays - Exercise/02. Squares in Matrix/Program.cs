namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] details = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[details[0], details[1]];

            int found = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] det = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = det[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        found++;
                    }
                }
            }

            Console.WriteLine(found);
        }
    }
}