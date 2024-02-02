﻿namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numbers.Any() == false)
            {
                return;
            }

            Func<int[], int> customMin = (int[] input) =>
            {
                int smallest = input[0];

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < smallest)
                    {
                        smallest = input[i];
                    }
                }

                return smallest;
            };

            Console.WriteLine(customMin(numbers));
        }
    }
}