using System.Security.Cryptography;

namespace _06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rowsCount][];

            for (int row = 0; row < jagged.Length; row++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                jagged[row] = new int[nums.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                        jagged[row][col] = int.Parse(nums[col]);
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] input = command.Split();
                string comm = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (comm == "Add")
                {
                    jagged[row][col] += value;
                }
                else
                {
                    jagged[row][col] -= value;
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}