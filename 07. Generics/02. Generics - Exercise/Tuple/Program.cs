﻿namespace Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] nameTokens = Console.ReadLine().Split();

            string[] beerTokens = Console.ReadLine().Split();

            string[] numberTokens = Console.ReadLine().Split();

            CustomTuple<string, string> names = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2]);
            CustomTuple<string, int> beers = new(beerTokens[0], int.Parse(beerTokens[1]));
            CustomTuple<int, double> numbers = new(int.Parse(numberTokens[0]), double.Parse(numberTokens[1]));

            Console.WriteLine(names);
            Console.WriteLine(beers);
            Console.WriteLine(numbers);
        }
    }
}
