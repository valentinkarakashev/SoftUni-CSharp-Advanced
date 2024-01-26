﻿namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] setsLength = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> first = new HashSet<int>();

            HashSet<int> second = new HashSet<int>();

            for (int i = 0; i < setsLength[0]; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < setsLength[1]; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }

            first.IntersectWith(second);

            foreach (var item in first)
            {
                Console.Write($"{item} ");
            }
        }
    }
}