using System.Threading.Channels;

namespace _07._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int removedKnights = 0;

            if (size < 3)
            {
                Console.WriteLine(0);
                return;
            }

            for (int row = 0; row < size; row++)
            {
                char[] symbols = Console.ReadLine().ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }

            while (true)
            {
                int maxAttack = 0;
                int rowMaxAttack = 0;
                int colMaxAttack = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        char currentElement = matrix[row, col];

                        if (currentElement == 'K')
                        {
                            int countAttackedKnights = CalculateAttackedKnight(row, col, size, matrix);

                            if (countAttackedKnights > maxAttack)
                            {
                                maxAttack = countAttackedKnights;
                                rowMaxAttack = row;
                                colMaxAttack = col;
                            }
                        }
                    }
                }

                if (maxAttack == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMaxAttack, colMaxAttack] = '0';
                    removedKnights++;
                }
            }

            Console.WriteLine(removedKnights);
        }

        static int CalculateAttackedKnight(int row, int col, int size, char[,] matrix)
        {
            int count = 0;

            if (IsValid(row - 2, col + 1, size))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    count++;
                }
            }

            if (IsValid(row - 2, col - 1, size))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    count++;
                }
            }

            if (IsValid(row + 2, col - 1, size))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    count++;
                }
            }

            if (IsValid(row + 2, col + 1, size))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    count++;
                }
            }

            if (IsValid(row + 1, col + 2, size))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    count++;
                }
            }

            if (IsValid(row - 1, col + 2, size))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    count++;
                }
            }

            if (IsValid(row - 1, col - 2, size))
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    count++;
                }
            }

            if (IsValid(row + 1, col - 2, size))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    count++;
                }
            }

            return count;
        }

        static bool IsValid(int row, int col, int size)
        {
            return (row >= 0 && row < size && col >= 0 && col < size);
        }
    }
}