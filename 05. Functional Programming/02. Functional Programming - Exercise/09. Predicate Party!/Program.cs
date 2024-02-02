﻿namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string commandType = commandArray[0];
                string commandCriteria = commandArray[1];

                Predicate<string> nameFunc = name =>
                {
                    if (commandCriteria == "StartsWith")
                    {
                        return name.StartsWith(commandArray[2]);
                    }
                    else if (commandCriteria == "EndsWith")
                    {
                        return name.EndsWith(commandArray[2]);
                    }
                    else if (commandCriteria == "Length")
                    {
                        return name.Length == int.Parse(commandArray[2]);
                    }
                    return false;
                };

                if (commandType == "Double")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        if (nameFunc(guests[i]))
                        {
                            guests.Insert(i, guests[i]);
                            i++;
                        }
                    }
                }
                else if (commandType == "Remove")
                {
                    for (int i = 0; i < guests.Count; i++)
                    {
                        if (nameFunc(guests[i]))
                        {
                            guests.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            if (guests.Count > 0)
            {
                Console.Write(string.Join(", ", guests));
                Console.Write(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}