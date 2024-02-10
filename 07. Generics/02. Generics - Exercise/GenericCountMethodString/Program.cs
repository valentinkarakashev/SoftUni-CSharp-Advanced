﻿namespace GenericCountMethodString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < lines; i++)
            {
                box.Add(Console.ReadLine());
            }

            string compareWith = Console.ReadLine();

            Console.WriteLine(box.Count(compareWith));
        }
    }
}
