namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            int sumDiagonalOne = 0;
            int sumDiagonalTwo = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] details = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = details[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col <= row; col++)
                {
                    sumDiagonalOne += matrix[row, col]; 
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - row - 1; col >= matrix.GetLength(1) - row - 1; col--)
                {
                    sumDiagonalTwo += matrix[row, col];
                }
            }

            Console.WriteLine(Math.Abs(sumDiagonalOne - sumDiagonalTwo));
        }
    }
}