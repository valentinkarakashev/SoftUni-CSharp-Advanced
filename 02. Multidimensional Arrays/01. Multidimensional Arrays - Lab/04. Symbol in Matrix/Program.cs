namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NxN = int.Parse(Console.ReadLine());

            char[,] matrix = new char[NxN, NxN];

            for (int row = 0; row < NxN; row++)
            {
                char[] data = Console.ReadLine().ToCharArray();

                for (int col = 0; col < data.Length; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < NxN; row++)
            {
                for (int col = 0; col < NxN; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}