﻿namespace LineNumbers 
{ 

    using System;

    public class LineNumbers
    {

        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++) 
            {
                int lettersNumber = lines[i].Where(char.IsLetter).Count();

                int punctuationMarks = lines[i].Where(char.IsPunctuation).Count();

                lines[i] = $"Line {i + 1}: {lines[i]} ({lettersNumber}) ({punctuationMarks})";
            }

            File.WriteAllLines(outputFilePath, lines);
        }
    }
}