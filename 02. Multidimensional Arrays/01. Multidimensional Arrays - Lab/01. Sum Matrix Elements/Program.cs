namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] counts = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[counts[0], counts[1]];

            int rowsCount = counts[0];
            int colsCount = counts[1];

            int sum = 0;

            for (int row = 0; row < rowsCount; row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = data[col];
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rowsCount);
            Console.WriteLine(colsCount);
            Console.WriteLine(sum);
        }
    }
}