﻿namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> predicate = i => i % divisor != 0;

            var result = input.Where(number => predicate(number)).ToArray();

            Console.WriteLine(string.Join(" ", result.Reverse()));
        }
    }
}