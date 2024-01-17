using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operationsCnt = int.Parse(Console.ReadLine());

            Stack<string[]> stack = new Stack<string[]>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < operationsCnt; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                int commandType = int.Parse(command[0]);

                if (commandType == 1)
                {
                    string stringToAdd = command[1];
                    string stringLength = stringToAdd.Length.ToString();
                    text.Append(stringToAdd);

                    string[] currentCommand = { "1", stringLength };
                    stack.Push(currentCommand);
                }
                else if (commandType == 2)
                {
                    int elementsToRemoveCnt = int.Parse(command[1]);
                    string removedString = text.ToString().Substring(text.Length - elementsToRemoveCnt, elementsToRemoveCnt);

                    string[] currentCommand = { "2", removedString };
                    stack.Push(currentCommand);
                    text.Remove(text.Length - elementsToRemoveCnt, elementsToRemoveCnt);
                }
                else if (commandType == 3)
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (commandType == 4)
                {
                    string[] undoCommand = stack.Pop();
                    int typeCommand = int.Parse(undoCommand[0]);

                    if (typeCommand == 1)
                    {
                        int length = int.Parse(undoCommand[1]);
                        text.Remove(text.Length - length, length);
                    }

                    else if (typeCommand == 2)
                    {
                        text.Append(undoCommand[1]);
                    }
                }
            }
        }
    }
}