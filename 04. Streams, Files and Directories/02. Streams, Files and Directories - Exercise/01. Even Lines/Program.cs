﻿namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main() 
        { 
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        } 
        
        public static string ProcessLines(string inputFilePath)
        {
            char[] cArray = { '-', ',', '.', '!', '?' };

            int lineCount = 0;

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                StringBuilder sb = new StringBuilder();

                string line;

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();

                    if (lineCount % 2 == 0)
                    {
                        foreach (var c in line)
                        {
                            if (cArray.Contains(c))
                            {
                                line = line.Replace(c, '@');
                            }
                        }

                        string[] temp = line.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Reverse().ToArray();

                        sb.AppendLine(string.Join(' ', temp));
                    }

                    lineCount++;
                }

                return sb.ToString();
            }
        } 
    } 
}