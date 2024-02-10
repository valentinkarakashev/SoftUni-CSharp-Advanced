﻿namespace GenericSwapMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                list.Add(Console.ReadLine());
            }

            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            GenericSwap(list, indexes[0], indexes[1]);

            foreach (var listItem in list)
            {
                Console.WriteLine($"{listItem.GetType()}: {listItem}");
            }
        }

        public static void GenericSwap<T>(List<T> items, int firstIndex, int secondIndex)
        {
            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }
    }
}
