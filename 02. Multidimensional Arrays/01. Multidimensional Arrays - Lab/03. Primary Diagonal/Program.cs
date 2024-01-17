namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NxN = int.Parse(Console.ReadLine());

            int[,] matrix = new int[NxN, NxN];

            int diagonalSum = 0;

            for (int row = 0; row < NxN; row++) 
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < data.Length; col++)
                {
                    matrix[row, col] = data[col];
                }
            }   

            for (int row = 0; row < NxN; row++)
            {
                for (int col = row; col <= row; col++)
                {
                    diagonalSum += matrix[row, col];
                }
            }

            Console.WriteLine(diagonalSum);
        }
    }
}